using System;

namespace HomeLib
{
	public class Team:IWorker
	{
		public string Name { get; set; }

		public TeamLeader leader;
		public Worker [] worker;		
	}
}
