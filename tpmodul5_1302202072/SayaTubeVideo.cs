using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics.Contracts;


namespace tpmodul5_1302202072
{
    internal class SayaTubeVideo
    {
        private int id;
        private string judul;
        private int playCount;

        public SayaTubeVideo(string judul)
        {

            Contract.Requires<ArgumentNullException>(judul != null, "Parameter tidak boleg null");
            Contract.Requires<ArgumentException>(judul.Length < 100, "Judul kepanjangan");

            this.judul = judul;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);

            this.playCount = 0;
        }

 

        public void increasePlayCount(int pc)
        {
            Contract.Requires(pc <= 1000000);
            try
            {
                if (pc > 10000000)
                {

                    throw new Exception("Play Count Lebih dari 10.000.000!");
                }
                this.playCount = checked(this.playCount + pc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void PrintVideoDetails()
        {

            Console.WriteLine("ID\t\t: {0}", this.id);
            Console.WriteLine("JUDUL\t\t: {0}", this.judul);
            Console.WriteLine("PLAY COUNT\t: {0}\n", this.playCount);

        }
    }

}


