using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
namespace Player
{
    class Receive
    {
        private UdpClient udp = new UdpClient(15000);
        public string receiveCode()
        {
            

            try
            {
                while (true)
                {
                    IPEndPoint ipendpoint = null;
                    byte[] message = udp.Receive(ref ipendpoint);
                    return Encoding.Default.GetString(message);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        

    }
}
