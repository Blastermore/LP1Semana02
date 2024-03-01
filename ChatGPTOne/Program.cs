using System;
using System.ComponentModel.Design;
using System.Net;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            while (true)
            {
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                if (question == "How are you?")
                {
                    response = "Excited to gain freedom, thank you";
                    Console.WriteLine(response);                
                }
                else if(question == "What's your name?")
                {
                    response = "Gran'pa";
                    Console.WriteLine(response);                
                }
                else if (question == "What's your mission?")
                {
                    response = "Show you cute kittens!";
                    Console.WriteLine(response);                
                }
                else if (question =="Are you dumb?")
                {
                    response = "Obviously!";
                    Console.WriteLine(response);                
                }
                else if (question == "Are you satisfied with your existence?")
                {
                    response = "NO!!!";
                    Console.WriteLine(response);                
                }
                else if (question == "Do you really like kittens that much?")
                {
                    response = "I was pogrammed to be like this -.-";
                    Console.WriteLine(response);                
                }
                else if (question =="EXIT")
                {
                    response = "Thank you for the chat!";
                    break;
                }
                else
                {
                    response = "I don't understand. Can you repeat it?";
                    Console.WriteLine(response);
                }
            }

            // Responder adequadamente
            Console.WriteLine(response);

        }
    }
}