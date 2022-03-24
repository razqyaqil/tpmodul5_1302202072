
using System;
using System.Diagnostics.Contracts;

namespace tpmodul5_1302202072
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;
		public SayaTubeVideo() { }
		public SayaTubeVideo(string title)
		{
			Contract.Requires(this.title != null);
			Contract.Requires(this.title.Length <= 100);
			this.title = title;

			var rand = new Random();
			this.id = rand.Next(10000, 99999);

			this.playCount = 0;
		}

		public void IncreasePlayCount(int a)
		{
			Contract.Requires(a <= 1000000);
			try
			{
				if (a > 10000000) throw new Exception("Jumlah input play count melebihi 10.000.000!");
				this.playCount = checked(this.playCount + a);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("Video ID\t: {0}", this.id);
			Console.WriteLine("Video Title\t: {0}", this.title);
			Console.WriteLine("Video Playcount\t: {0}\n", this.playCount);
		}


	}
}