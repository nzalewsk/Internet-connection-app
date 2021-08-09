using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace IP_Server
{
    public class SocketListener
    {
        //get these from form 1 later
        IPAddress ipAd = new IPAddress;
        readonly int port = new int();
        byte[] data = new Byte[1024];

        public void setIP(string address)
        {
            ipAd = Parse(address);
        }

        public byte[] getIP()
        {
            return ipAd;
        }

        //call this function from main when start button pushed
        //This function has a lot of lines taken from the source referenced at the top of main
        public void StartListening()
        {
            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPEndPoint remoteEP = new IPEndPoint(ipAd, 11000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAd.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(data);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(data, 0, bytesRec));

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// This app is the server, that will authenticate and allow connections
        /// 
        /// A lot of this code is taken from 
        /// https://docs.microsoft.com/en-us/dotnet/framework/network-programming/synchronous-client-socket-example
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //somehow i have to get values from form 1, and call socketlistener instance(s)
            bool button = false;
            string add;
            while(!button)
            {
                
            }
            SocketListener server;
            server.setIP(add);
        }
    }
}
