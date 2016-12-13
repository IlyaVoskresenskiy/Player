using System;

namespace Player
{
    class IpGet
    {
        public static string GetIP()
        {
            String host = System.Net.Dns.GetHostName();
            int i = 0;
            // Получение ip-адреса.
            while (true)
            {
               
                try
                {
                    System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[i];
                }
                catch (Exception)
                {
                    System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[i - 1];
                    return ip.ToString();
                    break;
                }
                i++;
            }
            
        }
    }
}