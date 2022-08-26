using LightBDD.NUnit3;
using RiverTech___Exercise_1__Web_API_.Models;
using RiverTech___Exercise_1__Web_API_.Views;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Text;
using System.Threading.Tasks;

namespace RiverTech___Exercise_1__Web_API_.Controllers
{
    public class UsersController
    {
        public static HttpClient client = new HttpClient();
        private static bool isInitialised;

        public static void InitialSetup()
        {
            if (isInitialised)
            {
                return;
            }

            // Update port # in the following line.
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            isInitialised = true;
        }

        public static async Task<HttpResponseMessage> ConnectWithAPIServer()
        {
            InitialSetup();

            try
            {
                // Get the user. URL provided by Rivertech
                HttpResponseMessage response = await client.GetAsync("users/1/");
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }

}
