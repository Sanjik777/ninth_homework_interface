using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Интерфейсы.

1.	Создать интерфейс IStudent: 
●	string Name { get; set; }
●	string FullName { get; set; }
●	int[] Grades { get; set; }
●	String GetName()
●	String GetFullName() 
●	Double GetAvgGrade() 
Наследовать от интерфейса класс Student и реализовать его.
*/
namespace practical_work
{
	public class Student : IStudent
	{
		public string Name { get; set; }
		public string FullName { get; set; }
		public int[] Grades	{get;set;}
		public String GetName()
		{
			return Name;
		}
		public String GetFullName()
		{
			return FullName;
		}
		public Double GetAvgGrade()
		{
			return Grades.Average();
		}
		public void Print()
		{
			Console.WriteLine($"\nFullName : {FullName}");
			Console.WriteLine($"Average grades :{Grades.Average()}");
			for (int i = 0; i < Grades.Length; i++)
			{
				Console.Write(Grades[i] + " ");
			}
		}
	}
}
