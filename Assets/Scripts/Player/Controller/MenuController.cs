using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : IController
{
    private Dictionary<KeyCode, ICommand> controlList;
    private Player player;
    private Vector2 horizontalMovement = Vector2.zero;
    public Vector2 HorizontalMovement
    {
        get { return horizontalMovement; }
        set { horizontalMovement = value; }
    }
    private Vector2 verticalMovement = Vector2.zero;
    public Vector2 VerticalMovement
    {
        get { return verticalMovement; }
        set { verticalMovement = value; }
    }
    private Vector2 knockback = Vector2.zero;
    public Vector2 Knockback
    {
        get { return knockback; }
        set { knockback = value; }
    }

    public MenuController(Player _player)
    {
        controlList = new Dictionary<KeyCode, ICommand>();
        player = _player;

        controlList.Add(KeyCode.Escape, new ExitMenu());
        controlList.Add(KeyCode.E, new MenuSelect());
        controlList.Add(KeyCode.LeftArrow, new MenuLeft());
        controlList.Add(KeyCode.UpArrow, new MenuUp());
        controlList.Add(KeyCode.DownArrow, new MenuDown());
        controlList.Add(KeyCode.RightArrow, new MenuRight());


    }

    public void Execute()
    {
        foreach (KeyCode key in controlList.Keys)
        {
            if (Input.GetKeyDown(key))
            {
                ICommand cmd = null;
                controlList.TryGetValue(key, out cmd);
                if (cmd != null)
                {
                    cmd.KeyDown();
                }
            }
            if (Input.GetKey(key))
            {
                ICommand cmd = null;
                controlList.TryGetValue(key, out cmd);
                if (cmd != null)
                {
                    cmd.KeyHeld();
                }
            }
            if (Input.GetKeyUp(key))
            {
                ICommand cmd = null;
                controlList.TryGetValue(key, out cmd);
                if (cmd != null)
                {
                    cmd.KeyUp();
                }
            }
        }
    }
}
