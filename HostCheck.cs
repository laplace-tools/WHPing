using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHPing
{
    internal class HostCheck
    {
        public static bool PingTarget(string host)
        {
            bool ret = false;
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply reply = ping.Send(host);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success) { ret = true; }
            ping.Dispose();

            return ret;
        }
    }
}
