using System;
using System.Collections;

namespace HomeLib
{
	public class House
	{
		public ArrayList parts;

		public House()
		{
			parts = new ArrayList();
		}
		public void Finish()
		{
			foreach(var i in parts)
			{
				if (i is IPart)
				{
					if ((i as IPart).IsReady)
					{
						Console.WriteLine($"Часть подходит");
						if (i.Equals(parts[parts.Count - 1]))
						{
							Console.WriteLine("\n    * ");
							Console.WriteLine("   * *");
							Console.WriteLine("  *   *");
							Console.WriteLine(" *     *");
							Console.WriteLine("*********");
							Console.WriteLine("*  ***  *");
							Console.WriteLine("*  ***  *");
							Console.WriteLine("*********");
						}
					}
					else { Console.WriteLine($"Одна из частей" +
					$" {i.ToString()} не готова");break; }
				}
				else { Console.WriteLine($"Одна из частей" +
					$" {i.ToString()} не подходит дому");break; }
			}
		}
	}
}