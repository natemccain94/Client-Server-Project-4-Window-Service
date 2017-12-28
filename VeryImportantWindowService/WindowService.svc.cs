using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantWindowService
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VeryImportantWindowService.IWindowService" />
    public class WindowService : IWindowService
    {
        /// <summary>
        /// Gets the window one value.
        /// </summary>
        /// <returns></returns>
        public string GetWindowOneVal()
        {
            Random rand = new Random();
            string answer;
            // Generate a random value
            switch (rand.Next(0, 4))
            {
                case 0:
                    answer = "OPEN";
                    break;
                case 1:
                    answer = "HALF-OPEN";
                    break;
                case 2:
                    answer = "CLOSED AND UNLOCKED";
                    break;
                default:
                    answer = "CLOSED AND LOCKED";
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the state of window one in the important person's office.");
            Console.WriteLine("The sensor reads: " + answer);
            return answer;
        }

        /// <summary>
        /// Gets the window two value.
        /// </summary>
        /// <returns></returns>
        public string GetWindowTwoVal()
        {
            Random rand = new Random();
            string answer;
            // Generate a random value
            switch (rand.Next(0, 4))
            {
                case 0:
                    answer = "OPEN";
                    break;
                case 1:
                    answer = "HALF-OPEN";
                    break;
                case 2:
                    answer = "CLOSED AND UNLOCKED";
                    break;
                default:
                    answer = "CLOSED AND LOCKED";
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the state of window two in the important person's office.");
            Console.WriteLine("The sensor reads: " + answer);
            return answer;
        }
    }
}
