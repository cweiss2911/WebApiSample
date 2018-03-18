﻿using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace Sample
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("http://localhost:9000/api/Values/fire");

                while (true)
                {

                }
            }
        }
    }
}