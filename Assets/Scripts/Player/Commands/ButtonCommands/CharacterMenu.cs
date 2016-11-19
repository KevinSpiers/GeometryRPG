using UnityEngine;
using System.Collections;

public class CharacterMenu : ICommand {
	private Player player;
	public CharacterMenu(Player _player)
	{
		player = _player;
	}
	
	public void KeyHeld()
	{
		
	}
	
	public void KeyDown()
	{
		//Game.TogglePausedGame();
		
		GameObject statsMenu = Game.GetStatsMenu ();
		statsMenu.SetActive (!statsMenu.activeSelf);
	}

    public void KeyUp()
    {

    }
}
