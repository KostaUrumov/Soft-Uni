using System;
using System.Collections.Generic;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());

            List<Song> list = new List<Song>();
            for (
                int i = 0; i < songsNumber; i++)
            {
                string songLine = Console.ReadLine();
                string [] songData = songLine.Split('_');


                Song song = new Song();
                song.TypeList = songData[0];
                song.Name = songData[1];
                song.time = (songData[2]);

                
                list.Add(song);
            }

            
           CallSongs(list);

           static void CallSongs(List<Song> list)
            {
                
             
                string playSong = Console.ReadLine();

                //if (playSong == list[i].TypeList)
                //{

                //}

                if (playSong == "all")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i].Name);

                    }
                }

                else if (playSong != "all")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].TypeList == playSong)
                        {
                            Console.WriteLine(list[i].Name);
                        }

                    }
                }

            }
        }

       
    }
}
