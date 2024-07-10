using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Menu
{
    public static class MenuText
    {
        public static void MainMenu(List<string> options)
        {
            Console.WriteLine("Welcome to our inventory system");


            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.WriteLine("Please enter a choice to procceed:");
        }
    }
}
