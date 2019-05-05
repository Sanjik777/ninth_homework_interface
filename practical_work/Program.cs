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
	class Program
	{
		static void Main(string[] args)
		{
			const int amountMark = 12;
			Student student = new Student();
			student.FullName = "Ivanov";
			student.Grades = new int[amountMark];
			for (int i = 0; i < student.Grades.Length; i++)
			{
				student.Grades[i] = i;
			}
			student.Print();
		}
	}
}
