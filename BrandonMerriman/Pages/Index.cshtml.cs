using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BrandonMerriman.Views
{
    public class IndexModel : PageModel
    {
        public string Greeting { get; set; }
        public void OnGet()
        {
            List<string> possibleGreetings = new List<string>
            {
                "Hey there.",
                "What's good?",
                "Good to see you.",
                "Hi!",
                "Salve!",
                "What's up?",
                "Howdy do?"
            };
            Random greetingSelector = new Random();
            Greeting = possibleGreetings[greetingSelector.Next(0, possibleGreetings.Count)];
        }
    }
}