using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework3.Models
{
    public static class TempStorage 
    {
        private static List<MovieModel> applications = new List<MovieModel>();

        public static IEnumerable<MovieModel> Applications => applications;

        public static void AddApplication(MovieModel application)
        {
            applications.Add(application);
        }

    }
}
