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
        private static HttpResponseMessage _response;

        public static HttpResponseMessage Response { get => _response; set => _response = value; }

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
                // Get the user and confirm that URL is valid. URL provided by Rivertech
                _response = await client.GetAsync("users/1/");
                return _response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }

}
