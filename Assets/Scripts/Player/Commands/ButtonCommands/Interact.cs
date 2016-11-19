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
        if (!Game.GamePaused && player.stats.Health > 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            if (player.items.Weapon != null)
            {
                player.items.Weapon.UseWeapon();
            }
        }
    }

    public void KeyUp()
    {

    }
}