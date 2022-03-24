// See https://aka.ms/new-console-template for more information
using System;

namespace tpmodul5_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vidio = new SayaTubeVideo("Tutorial Design By Contract – Abdullah Razqy Aqil");
            vidio.printVideoDetails();
            
            vidio.increasePlayCount(69);
            vidio.printVideoDetails();

            vidio.increasePlayCount(69);
            vidio.printVideoDetails();

        }
    }
}
