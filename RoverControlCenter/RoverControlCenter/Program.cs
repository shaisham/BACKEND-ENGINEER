using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating objects
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            //calling methods on all array objects
            Rover[] rovers = { lunokhod, apollo, sojourner };
            //DirectAll(rovers);

            //Array of all probe objects using Interface type
            IDirectable[] iprobes = { lunokhod, apollo, sojourner, sputnik };
            DirectAll(iprobes);

            //following checking the tyoe of the objects/instance created in console
            Object[] probes = { lunokhod, apollo, sojourner, sputnik };
            Console.WriteLine("\n");
            foreach (Object probe in probes)
            {
                Console.WriteLine($"Tracking a {probe.GetType()}…");
            }
            Console.ReadLine();
        }

        //method for calling and printing return strings in console using foreach loop
        public static void DirectAll(IDirectable[] iprobes)
        {
            foreach (IDirectable iprobe in iprobes)
            {
                Console.WriteLine(iprobe.GetInfo());
                Console.WriteLine(iprobe.Explore());
                Console.WriteLine(iprobe.Collect() + "\n");
            }

        }
    }
}