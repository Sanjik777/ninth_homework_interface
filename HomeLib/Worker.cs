using System;
using System.Threading;

namespace HomeLib
{
	public class Worker : IWorker
	{
		const int maxPercentage = 100;
		public string Name { get; set; }
		public int Progress { get; set; }

		public void Build(IPart PartOfHome)
		{
			Progress = 0;
			int PosY = Console.CursorTop;
			int PosX = Console.CursorLeft;

			while (Progress < maxPercentage)
			{
				Progress++;
				Console.Write($"строится {Progress}");
				Console.SetCursorPosition(PosX, PosY);
				Thread.Sleep(10);
			}
			if (Progress == maxPercentage)
			{
				PartOfHome.IsReady = true;
			}
		}
	}
}