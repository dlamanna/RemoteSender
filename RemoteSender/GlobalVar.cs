using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace RemoteSender
{
    public class GlobalVar
    {
        public static TcpClient client = null;
        public static IPEndPoint serverEndpoint = null;
        public static int portNum = 6789;
        public static string message = "";
        public static string ipaddress = "192.168.1.2";

        public static void connect()
        {
            Regex numberIP = new Regex("^[0-9]{1-3}.{1}[0-9]{1-3}.{1}[0-9]{1-3}.{1}[0-9]{1-3}");

            client = new TcpClient();
            //if (numberIP.IsMatch(ipaddress))
            //{
            //    serverEndpoint = new IPEndPoint(IPAddress.Parse(ipaddress), portNum);
            //    client.Connect(serverEndpoint);
            //}
            //else
            //{
            //    client.Connect(ipaddress, portNum);
            //    Process.Start("ToolTipper.exe", "Error Bad IP or Hostname");
            //}

            serverEndpoint = new IPEndPoint(IPAddress.Parse(ipaddress), portNum);
            client.Connect(serverEndpoint);
            NetworkStream clientStream = client.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(message);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            Application.Exit();
        }
    }
}
