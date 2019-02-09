using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static async Task Get()
        {
            await Task.Run(() => {
                Thread.Sleep(500);
                Console.WriteLine("Async get first");
            });

            Console.WriteLine("Async get second");
        }
    }
}
