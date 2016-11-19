using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Ability3 : ICommand {
	Player player;
	public Ability3(Player _player)
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
			player.characterClass.am.UseAbility (2);
		}
	}

	public void KeyUp()
	{

	}
}