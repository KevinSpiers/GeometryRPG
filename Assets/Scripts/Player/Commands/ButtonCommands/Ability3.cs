﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Ability3 : ICommand
{
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