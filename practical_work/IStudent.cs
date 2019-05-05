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
	public interface IStudent
	{
		string Name { get; set; }
		string FullName { get; set; }
		int[] Grades { get; set; }
		String GetName();
		String GetFullName();
		Double GetAvgGrade();
	}
}
