using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Ability2 : ICommand {
	Player player;
	public Ability2(Player _player)
	{
		player = _player;
	}

	public void KeyDown()
	{
		//Do Something
	}

	public void KeyHeld()
	{
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			player.characterClass.am.UseAbility (1);
		}
	}

	public void KeyUp()
	{

	}
}