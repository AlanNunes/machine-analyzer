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
            string[] hosts = { "alanusdevelopment.com", "google.com.br", "youtube.com" };

            Machine machine = new Machine();

            foreach (string host in hosts)
            {
                machine.Host = host;
                Console.WriteLine(machine.IsAvailable(12000));
            }

            Console.Read();
        }
    }
}
