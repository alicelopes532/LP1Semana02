using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            Console.WriteLine("ChatGPTZero activated! Type 'exit' to quit.");

            while (true)
            {
                // Solicita uma pergunta
                Console.Write("\nPlace your question? ");
                question = Console.ReadLine();

                // Permitir saída do loop
                if (question.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // Verifica a questão (case insensitive)
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
                        response = "You got me, I'm not THAT smart!";
                        break;
                }

                // Exibe a resposta
                Console.WriteLine(response);
            }
        }
    }
}
