using RiverTech___Exercise_1__Web_API_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiverTech___Exercise_1__Web_API_.Views
{
    public class UserView
    {
        public static void ShowUser(User user)
        {
            Console.WriteLine($"Name: {user.Name}\tPhone: " +
                $"{user.Phone}\tWebsite: {user.Website}");
        }
    }
}
