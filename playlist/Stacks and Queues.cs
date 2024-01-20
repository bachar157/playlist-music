  using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace playlist
{
    internal  class Stacks_and_Queues
    {
        Queue<string> playlist = new Queue<string>();
        Stack<string> stackplayList = new Stack<string>();


        public  string AddSong()
        {

            Console.Write(" enter the song that you want to add :> ");
            string songName = Console.ReadLine();
            // Add the user-input song to the playlist
            playlist.Enqueue(songName);
            Console.Write($"{songName} has been added to your playlist ");
            Console.WriteLine($"nnnn {playlist.Count} ");
            if (playlist.Count > 0)
            {
                Console.WriteLine($"Next song: {playlist.Peek()}");
            }

            return songName;
        }
        public void PlayTheNextSong()
        {
            string currentSong = playlist.Peek();
            string nextSong = playlist.Dequeue();
            Console.Write($" now :{currentSong}  ");
            Console.Write($" next :{nextSong} ");


        }
        public void SkipTheNextSong()
        {
            string SkipNext = playlist.Dequeue();
            string NextofNext = playlist.Dequeue();
            Console.Write($" you skip  {SkipNext} to {NextofNext}  ");

        }
        public void rewindOneSong()
        {
            foreach (string item in playlist)
            {
                stackplayList.Push(item);

            }
            string topSong = stackplayList.Pop(); // Temporarily remove the top song
            string previousSong = stackplayList.Peek();
            Console.WriteLine($" you rewind one song to {previousSong} ");
            stackplayList.Push(topSong); // Put the top song back


        }






    }
}
