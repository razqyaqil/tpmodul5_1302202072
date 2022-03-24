using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302202072
{
    internal class SayaTubeVideo
    {
        private int id;
        private string judul;
        private int playCount;

        public SayaTubeVideo(string judul)
        {
            this.judul = judul;
            Random rnd = new Random();

            this.id = rnd.Next(10000,99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int pc)
        {
            if(this.playCount == 0)
            {
                this.playCount = pc;
            }
            else
            {
                this.playCount += pc;
            }
            
        }
        public void printVideoDetails()
        {
            Console.WriteLine("ID\t\t: {0}",this.id);
            Console.WriteLine("JUDUL\t\t: {0}",this.judul);
            Console.WriteLine("PLAY COUNT\t: {0}\n", this.playCount);

        }
    }
}
