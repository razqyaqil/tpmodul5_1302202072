// See https://aka.ms/new-console-template for more information
using System;

namespace tpmodul5_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            SayaTubeVideo vidio = new SayaTubeVideo("Tutorial Design By Contract - Abdullah Razqy Aqil");
            vidio.PrintVideoDetails();

            vidio.IncreasePlayCount(69);
            vidio.PrintVideoDetails();

            try
            {
                vidio.IncreasePlayCount(1900000000);
                vidio.PrintVideoDetails();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }













        }
    }
}
