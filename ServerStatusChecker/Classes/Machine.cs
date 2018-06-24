using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace MachineAnalyzer.Classes
{
    class Machine
    {
        // Store host name as well as ip adress
        public string Host { get; set; }

        // Says if the machine is online/offline
        public PingReply IsAvailable(int timeout)
        {
            Ping ping = new Ping();
            PingOptions options = new PingOptions(64, true);

            // Data in 32 bytes to be sent
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Save the data as bytes(32)
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            // Pings the host
            // 
            // Parameters
            // timeout Maximo time of response
            // buffer Data to be sent to machine host
            PingReply reply = ping.Send(this.Host, timeout, buffer);

            if (reply.Status.ToString() == "Success")
            {
                return reply;
            }
            else
            {
                return reply;
            }
        }
    }
}
