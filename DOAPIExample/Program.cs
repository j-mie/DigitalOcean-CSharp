using System;
using System.IO;
using DigitalOcean;
using DigitalOcean.Structs;

namespace DOAPI.Example
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
            
            var images = client.GetImages();
            foreach (Image image in images.images)
            {
                Console.WriteLine("Image Name: {0} with ID {1}", image.name, image.id);
            }

            var centosimg = client.GetImage(1601).image;
            Console.WriteLine("Manual image lookup name: {0} with ID {1}", centosimg.name, centosimg.id);

            var regions = client.GetRegions();
            foreach (Region region in regions.regions)
            {
                Console.WriteLine("Region Name: {0} with ID {1}", region.name, region.id);
            }

            var sizes = client.GetSizes();
            foreach (Size size in sizes.sizes)
            {
                Console.WriteLine("Size Name: {0} with ID {1}", size.name, size.id);
            }


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
