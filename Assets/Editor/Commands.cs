using UnityEngine;
using System.Collections;

using Completed;

using LunarPlugin;

#region Days Management

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

#endregion

#region Food Management

[CCommand("food")]
class Cmd_food : CPlayModeCommand
{
	bool Execute(int food)
	{
		Player player = GameObject.FindObjectOfType<Player>();
		if (player == null)
		{
			PrintError("Player not found");
			return false;
		}
		
		player.Food = food;
		return true;
	}
}

#endregion