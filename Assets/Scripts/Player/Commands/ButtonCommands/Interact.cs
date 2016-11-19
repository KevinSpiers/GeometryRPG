using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Interact : ICommand
{
    Player player;
    public Interact(Player _player)
    {
        player = _player;
    }

    public void KeyDown()
    {
        //Do Nothing
    }

    public void KeyHeld()
    {
		if (!Game.GamePaused && player.characterClass.ps.Health > 0)
        {
            
        }
    }

    public void KeyUp()
    {

    }
}