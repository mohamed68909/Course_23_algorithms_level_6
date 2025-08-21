using System.Runtime.CompilerServices;

namespace Course_23_algorithms_level_6
{
    internal class Program
    {

        public class Browser
        {
            private Stack<string> history = new Stack<string>();
            public void VisitPage(string url)
            {
                history.Push(url);
                Console.WriteLine($"Visited: {url}");
            }
            public void Back()
            {
                if (history.Count > 1)
                {
                    history.Pop(); 
                    string previousPage = history.Peek(); 
                    Console.WriteLine($"Back to: {previousPage}");
                }
                else
                {
                    Console.WriteLine("No previous page to go back to.");
                }
            }
        }
        static void Main(string[] args)
        {
            //Problem: Use a stack to implement a browser's back button functionality.

            Browser browser = new Browser();
            browser.VisitPage("https://example.com");
            browser.VisitPage("https://example.com/page1");
            browser.VisitPage("https://example.com/page2");
            browser.Back();
            browser.Back();
            browser.Back(); 


        }
    }
}
