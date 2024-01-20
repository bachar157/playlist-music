using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks_and_Queues addSong = new Stacks_and_Queues();
            bool exitProgram = false;
            while (exitProgram == false)
            {
                Console.WriteLine(" ------------------------------------------ ");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a song to your playlist");
                Console.WriteLine("2. Play the next song in your playlist");
                Console.WriteLine("3. Skip the next song");
                Console.WriteLine("4. Rewind one song");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string userinput = Console.ReadLine();
               


                switch (userinput)
                {
                    case "1":
                        addSong.AddSong();
                        break;

                    case "2":
                        addSong.PlayTheNextSong();
                        break;

                    case "3":
                        addSong.SkipTheNextSong();
                        break;

                    case "4":
                        addSong.rewindOneSong();
                        break;

                    case "5":
                        // Exit the program

                        Console.WriteLine("you exit the program  ");
                        exitProgram = true;
                        Thread.Sleep(5000); // Sleeps for 5000 milliseconds, or 5 seconds
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine(); // Add an empty line for better readability
            }
        }

    }
    
}
