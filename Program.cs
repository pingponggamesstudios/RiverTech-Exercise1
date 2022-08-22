using RiverTech___Exercise_1__Web_API_.Controllers;
using RiverTech___Exercise_1__Web_API_.Models;
using RiverTech___Exercise_1__Web_API_.Views;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RiverTech___Exercise_1__Web_API_
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersController.RunAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }
    }
}
