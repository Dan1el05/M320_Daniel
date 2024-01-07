using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class Simulator
    {

       StringStack historyStack = new StringStack(10);
        StringStack forwardStack = new StringStack(10);

        private string currentUrl;

        private string currentURL = "";
   
        public void Run()
        {
            while (true) {

            Console.Clear();
            DisplayURL();
            Console.Write("Bitte geben Sie eine URL ein: ");
            string url =  Console.ReadLine();

                switch (url)
                {
                    case "e":
                        Environment.Exit(0);
                        break;
                    case "u":
                        Undo();
                        break;

                    case "f":
                        Redo(); 
                        break;


                    default:
                        BrowseURL(url);
                        break;
                }
           

            }

        }

     private void BrowseURL(string url)
        {
            if (!string.IsNullOrEmpty(currentUrl))
            {
                
                historyStack.Push(currentUrl);
                forwardStack.Clear();
               

            }

            currentURL = url;


        }

        private void Undo() 
        {
            if (historyStack.Count > 0)
            {
                forwardStack.Push(currentURL);
                currentURL = historyStack.Pop();
            }
            else
            {
                Console.WriteLine("Der Stack ist leer"); 
            }
            
        }

        private void Redo()
        {
            if (forwardStack.Count > 0)
            {
                historyStack.Push(currentURL);
                currentURL = forwardStack.Pop();
            }
            else
            {
                Console.WriteLine("Der Stack ist leer");
            }

        }

        private void DisplayURL()
        {
            Console.WriteLine($"Die Aktuelle URL ist {currentUrl}");
        }
    }
}
