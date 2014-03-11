using System;
using System.IO;
using DigitalOcean;
using DigitalOcean.Structs;

namespace DOAPITest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sw = new StreamReader("authdetails.conf");

            string ClientID = sw.ReadLine();
            string APIKey = sw.ReadLine();

            DOClient client = new DOClient(ClientID, APIKey);
            Console.WriteLine("Using ClientID: {0} and APIKey: {1}", ClientID, APIKey);

            var droplets = client.GetDroplets();

            foreach (Droplet droplet in droplets.droplets)
            {
                Console.WriteLine(droplet.name);
                Console.WriteLine(droplet.ip_address);
                Console.WriteLine(droplet.status);
            }
            
            
            Console.ReadLine();
        }
    }
}
