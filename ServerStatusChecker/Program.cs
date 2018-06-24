using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using MachineAnalyzer.Classes;
using System.Diagnostics;

namespace MachineAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // All hosts to be verified
            string[] hosts =
                {
                "alanusdevelopment.com",
                "google.com.br",
                "youtube.com",
                "nead.ugb.edu.br",
                "192.168.1.1"
                };

            Machine machine = new Machine();
            Mails mail = new Mails();

            foreach (string host in hosts)
            {
                machine.Host = host;
                var response = machine.IsAvailable(12000);
                if (response.Status.ToString() == "Success")
                {
                    Console.WriteLine(host + " is online. It has walked through " + response.Options.Ttl + " " +
                        "routers or gateways");
                }
                else
                {
                    // Parameters
                    //
                    // string to
                    // string host
                    // string subject
                    // string body
                    mail.Send("alann.625@gmail.com", host + " IS OUT OF CONNECTION",
                       "Hi, the connection with <b>" + host + "</b> was not successfull" +
                       "<br/><b>Details:</b><br/><b>Status:</b>" + response.Status);
                }
            }

            Console.Read();
        }
    }
}
