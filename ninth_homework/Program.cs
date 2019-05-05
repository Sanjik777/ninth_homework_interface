using HomeLib;
using System;
/*
Интерфейсы.

1.	Реализовать программу “Строительство дома” 
Реализовать: 
●	Классы
○	House (Дом), Basement (Фундамент), Walls (Стены), Door (Дверь), Window (Окно), Roof (Крыша);
○	Team (Бригада строителей), Worker (Строитель), TeamLeader (Бригадир).
●	Интерфейсы
○	IWorker, IPart.
Все части дома должны реализовать интерфейс IPart (Часть дома), для рабочих
и бригадира предоставляется базовый интерфейс IWorker (Рабочий).
Бригада строителей (Team) строит дом (House). Дом состоит из фундамента (Basement),
стен (Wall), окон (Window), дверей (Door), крыши (Part).
Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша. 
Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента.
Каждый строитель не знает заранее, на чём завершился предыдущий этап строительства,
поэтому он “проверяет”, что уже построено и продолжает работу.
Если в игру вступает бригадир (TeamLeader), он не строит,
а формирует отчёт, что уже построено и какая часть работы выполнена. 
В конечном итоге на консоль выводится сообщение, что строительство дома завершено
и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).
*/

namespace ninth_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			const int amount = 4;

			//строиматериалы
			Console.WriteLine("Заготавливаем стройматериалы");
			Basement basement = new Basement();
			Wall[] walls = new Wall[amount];
			for(int i=0; i < walls.Length; i++)
			{
				walls[i] = new Wall();
			}
			Window[] windows = new Window[amount];
			for (int i = 0; i < windows.Length; i++)
			{
				windows[i] = new Window();
			}
			Roof roof = new Roof();
			Door door = new Door();

			//команда
			Team team = new Team();
			team.leader = new TeamLeader();
			team.leader.Name = "Vovan";
			team.worker = new Worker[amount];
			for (int i = 0; i < team.worker.Length; i++)
			{
				team.worker[i] = new Worker();
			}
			team.worker[0].Name = "Vasyan";
			team.worker[1].Name = "Petr";
			team.worker[2].Name = "Ravshan";
			team.worker[3].Name = "RD2D2";
			Console.WriteLine("Бригадир говорит команде начать работу\n\n");

			//команда строит
			team.worker[0].Build(basement);
			team.leader.Check(team.worker[0],basement);

			team.worker[1].Build(walls[0]);
			team.leader.Check(team.worker[1],walls[0]);

			team.worker[2].Build(walls[1]);
			team.leader.Check(team.worker[2], walls[1]);

			team.worker[3].Build(walls[2]);
			team.leader.Check(team.worker[3], walls[2]);

			team.worker[0].Build(walls[3]);
			team.leader.Check(team.worker[0], walls[3]);


			team.worker[1].Build(roof);
			team.leader.Check(team.worker[1], roof);


			team.worker[0].Build(windows[0]);
			team.leader.Check(team.worker[0], windows[0]);

			team.worker[1].Build(windows[1]);
			team.leader.Check(team.worker[1], windows[1]);

			team.worker[2].Build(windows[2]);
			team.leader.Check(team.worker[2], windows[2]);

			team.worker[3].Build(windows[3]);
			team.leader.Check(team.worker[3], windows[3]);

			team.worker[0].Build(door);
			team.leader.Check(team.worker[0], door);

			House house = new House();
			house.parts.Add(basement);
			house.parts.Add(walls[0]);
			house.parts.Add(walls[1]);
			house.parts.Add(walls[2]);
			house.parts.Add(walls[3]);
			house.parts.Add(roof);
			house.parts.Add(windows[0]);
			house.parts.Add(windows[1]);
			house.parts.Add(windows[2]);
			house.parts.Add(windows[3]);
			house.parts.Add(door);
			house.Finish();
			Console.ReadKey();
		}
	}
}
