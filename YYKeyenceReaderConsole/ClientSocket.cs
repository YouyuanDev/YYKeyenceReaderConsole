using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
/// <summary>
/// Kurt Youyuan tech 2018.
/// </summary>

namespace YYKeyenceReaderConsole
{
    class ClientSocket
    {
        public Socket commandSocket;   // socket for command
        public Socket dataSocket;      // socket for data
        public IPEndPoint readerCommandEndPoint;
        public IPEndPoint readerDataEndPoint;


        public ClientSocket(byte[] ipAddress, int readerCommandPort, int readerDataPort)
        { 
            IPAddress readerIpAddress = new IPAddress(ipAddress);
            readerCommandEndPoint = new IPEndPoint(readerIpAddress, readerCommandPort);
            readerDataEndPoint = new IPEndPoint(readerIpAddress, readerDataPort);
            commandSocket = null;
            dataSocket = null;
        }


        public ClientSocket(string ipAddress, int readerCommandPort, int readerDataPort)
        {
            IPAddress readerIpAddress = IPAddress.Parse(ipAddress);
            readerCommandEndPoint = new IPEndPoint(readerIpAddress, readerCommandPort);
            readerDataEndPoint = new IPEndPoint(readerIpAddress, readerDataPort);
            commandSocket = null;
            dataSocket = null;
        }
    }
}
