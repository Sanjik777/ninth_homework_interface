using System;

namespace HomeLib
{
	public class TeamLeader : IWorker
	{
		public string Name { get; set; }
		public void Check(Worker worker, IPart PartOfHome)
		{
			if (PartOfHome.IsReady)
			{
				if (PartOfHome is Basement)
				{
					Console.WriteLine("\nПостроено : Фундамент\n");
				}
				else if (PartOfHome is Wall)
				{
					Console.WriteLine("\nПостроено : Стена\n");
				}
				else if (PartOfHome is Roof)
				{
					Console.WriteLine("\nПостроено : Крыша\n");
				}
				else if (PartOfHome is Window)
				{
					Console.WriteLine("\nПостроено : Окно\n");
				}
				else if (PartOfHome is Door)
				{
					Console.WriteLine("\nПостроено : Дверь\n");
				}
			}
			else { Console.WriteLine("\nНе построено\n"); }
		}
	}
}
