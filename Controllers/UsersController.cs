using RiverTech___Exercise_1__Web_API_.Models;
using RiverTech___Exercise_1__Web_API_.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RiverTech___Exercise_1__Web_API_.Controllers
{
    public class UsersController
    {
        static HttpClient client = new HttpClient();

        public static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                User user = new User();

                // Get the user. URL provided by Rivertech
                user = await GetUserAsync("users/1/");
                UserView.ShowUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static async Task<User> GetUserAsync(string path)
        {
            User user = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }
    }

}
