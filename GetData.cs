using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace Player
{
    class Receive
    {
        void OnUdpData(IAsyncResult result)
        {
            string select = null;
            UdpClient socket = result.AsyncState as UdpClient;
            IPEndPoint source = new IPEndPoint(0, 0);
            byte[] message = socket.EndReceive(result, ref source);
            select = Encoding.Default.GetString(message);
            switch(select)
            {
                case "1":
                    Play_f.myForm.next_button.BeginInvoke(
                    ((Action)(() => {
                        Play_f.myForm.next_button.PerformClick();
                        Send(Play_f.myForm.music_list.GetItemText(Play_f.myForm.music_list.SelectedItem), source);
                    }
                    )));
                    break;
                case "-1":
                    Play_f.myForm.next_button.BeginInvoke(
                     ((Action)(() => {
                         Play_f.myForm.back_button.PerformClick();
                         Send(Play_f.myForm.music_list.GetItemText(Play_f.myForm.music_list.SelectedItem), source);
                     }
                     )));
                    break;
                case "0":
                    Play_f.myForm.next_button.BeginInvoke(
                    ((Action)(() => {
                        Play_f.myForm.click_pause();
                        Send(Play_f.myForm.music_list.GetItemText(Play_f.myForm.music_list.SelectedItem), source);
                    }
                    )));
                    break;
                default:
                    break;
            }    
            socket.BeginReceive(new AsyncCallback(OnUdpData), socket);
        }
        public void Send(string mess, IPEndPoint Ip)
        {

            UdpClient udp = new UdpClient();
            Console.WriteLine(Ip);
            byte[] message = Encoding.Default.GetBytes(mess);
            int sended = udp.Send(message, message.Length, Ip);
            udp.Close();
        }

        private UdpClient socket = new UdpClient(15000);
        public void receiveCode()
        {
            socket.BeginReceive(new AsyncCallback(OnUdpData), socket);
        }
    }
}
