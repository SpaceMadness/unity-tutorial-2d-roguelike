using UnityEngine;
using System.Collections;

using Completed;

using LunarPlugin;

[CCommand("restart", Description="Restarts current day")]
class Cmd_restart : CPlayModeCommand
{
	void Execute()
	{
		GameManager.instance.RestartDay();
	}
}

[CCommand("next", Description="Starts next day")]
class Cmd_next : CPlayModeCommand
{
	void Execute()
	{
		GameManager.instance.NextDay();
	}
}

[CCommand("prev", Description="Starts prev day")]
class Cmd_prev : CPlayModeCommand
{
	void Execute()
	{
		GameManager.instance.PrevDay();
	}
}

[CCommand("day", Description="Starts Nth day")]
class Cmd_day : CPlayModeCommand
{
	void Execute(int day)
	{
		GameManager.instance.StartDay(day);
	}
}