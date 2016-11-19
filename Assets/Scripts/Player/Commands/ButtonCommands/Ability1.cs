using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Ability1 : ICommand {
	Player player;
	public Ability1(Player _player)
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
			player.characterClass.am.UseAbility (0);
		}
	}

    public void KeyUp()
    {

    }
}