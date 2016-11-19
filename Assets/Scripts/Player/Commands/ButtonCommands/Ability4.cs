using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Ability4 : ICommand {
	Player player;
	public Ability4(Player _player)
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
			player.characterClass.am.UseAbility (3);
		}
	}

	public void KeyUp()
	{

	}
}