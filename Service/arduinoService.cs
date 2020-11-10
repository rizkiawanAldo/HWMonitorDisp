using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using HWMonitorDisp.Response;
using System.IO.Ports;

namespace HWMonitorDisp.Service
{
    class arduinoService
    {
        private bool sync = false;
        private byte[] receivedBytes = new byte[27];
        private List<byte> readBuffer = new List<byte>();
       
      //Fixed frame 27 bytes
      private const byte stx = 2, etx = 3, dle = 10;
     //<stx><dle><24 data bytes><etx>
      

        //private char[] _dataRecieved = new char[9];

        private SerialPort port = new SerialPort();

        public arduinoResponse AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);


            arduinoResponse result = new arduinoResponse();

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    List<detectedCom> data = new List<detectedCom>();

                    detectedCom _com = new detectedCom();
                    _com.DeviceID = deviceId;
                    _com.Desc = desc;

                    data.Add(_com);
                    result.comList = data;

                    if (desc.Contains("Arduino"))
                    {
                        result.autoSelected = item["DeviceID"].ToString();
                        result.selectedDesc = item["Description"].ToString();
                        return result;
                    }
                }
                return result;
            }
            catch (ManagementException e)
            {
                throw e;
                /* Do Nothing */
            }


        }

        public void ConnectArduino(object deviceID)
        {
            
            port.PortName = deviceID.ToString();
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
            port.Handshake = Handshake.None;
            port.RtsEnable = true;
            port.BaudRate = 9600;
            port.DataReceived += new SerialDataReceivedEventHandler (DataRecieved);

            if (!port.IsOpen)
            {
                port.Open();
                port.Write("<HS:S>");                
            }
        }
        public void DisconnectArduino()
        {
            port.Write("<DIS>");
            port.Close();

        }
        public void DataRecieved(object sender, object e)
        {
            string data = "<stx><dle><HS:HS><etx>";

            if (!port.IsOpen) return;
            if (sync) //one complete and valid packet was received
            {
                byte[] buffer = new byte[27];// packet size
                int bytes = port.BytesToRead;
                if (bytes > 26) //check if at least one packet has arrived
                {
                    port.Read(buffer, 0, 27);
                    if (buffer[0] == stx && buffer[1] == dle && buffer[26] == etx)
                    {
                        sync = true;//packet was valid
                        receivedBytes = new byte[27];
                        receivedBytes = buffer;
                        //processData(receivedBytes); //Do things with data received (remove stx,dle and etx)
                        port.Write((1, 0, data.Length).ToString()); //Send 0x01 as handshake
                    }
                    else
                    {
                        port.DiscardInBuffer();//Start over
                        sync = false;
                        if (readBuffer.Count > 0) readBuffer = new List<byte>();
                    }
                }
            }
            if (!sync)
            {
                while (port.BytesToRead > 0)//read until one complete valid packet is received
                {
                    int indata = port.ReadByte();
                    //Check for startbyte stx
                    if (indata == (int)stx && readBuffer.Count == 0)
                    {
                        readBuffer.Add((byte)indata);
                        indata = port.ReadByte();//Read next byte
                    }
                    else
                    {
                        port.DiscardInBuffer();//Start over
                        sync = false;
                        if (readBuffer.Count > 0) readBuffer = new List<byte>();
                    }
                    //Check for data delimiter dle
                    if (indata == (int)dle && readBuffer.Count == 1)
                    {
                        readBuffer.Add((byte)indata);
                        indata = port.ReadByte();// Read next byte
                    }
                    else
                    {
                        port.DiscardInBuffer();//Start over
                        sync = false;
                        if (readBuffer.Count > 0) readBuffer = new List<byte>(); //Clear readbuffer
                    }
                    while (readBuffer.Count > 1 && readBuffer.Count < 28)// Read data
                    {
                        readBuffer.Add((byte)indata);
                        indata = port.ReadByte();// Read next byte
                    }
                    if (readBuffer.Count == 27 && indata == (int)etx)// Check if last byte (26) = etx
                    {
                        sync = true;
                        readBuffer.Add((byte)indata);
                        receivedBytes = new byte[27];
                        receivedBytes = readBuffer.ToArray();
                        //processData(receivedBytes);//Do things with data received (remove stx,dle and etx)
                        port.Write((1, 0, 1).ToString()); //Send 0x01 as handshake
                        readBuffer = new List<byte>();
                    }
                    else //Start over
                    {
                        sync = false;
                        readBuffer = new List<byte>();//Cleares readbuffer
                    }
                }
            }

        }
    }
}
