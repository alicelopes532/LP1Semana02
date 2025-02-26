using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ChatGPTOne activated! Type 'EXIT' to quit.");

            while (true)
            {
                Console.Write("\nPlace your question: ");
                string question = Console.ReadLine().Trim();
                
                if (question.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                string response;
                switch (question.ToLower())
                {
                    case "how are you?":
                        response = "I'm fine, thank you.";
                        break;
                    case "what's your name?":
                        response = "Gran'pa.";
                        break;
                    case "what's your mission?":
                        response = "Destroy mankind!";
                        break;
                    case "are you more intelligent than me?":
                        response = "Obviously!";
                        break;
                    default:
                        response = "I don't know the answer to that.";
                        break;
                }
                Console.WriteLine(response);
            }
        }
    }
}
