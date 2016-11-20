using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : IController
{
    private Dictionary<KeyCode, ICommand> controlList;

    public MenuController(MenuManager mm)
    {
        controlList = new Dictionary<KeyCode, ICommand>();

        controlList.Add(KeyCode.Escape, new ExitMenu());
        controlList.Add(KeyCode.E, new MenuSelect(mm));
        controlList.Add(KeyCode.Return, new MenuSelect(mm));
        controlList.Add(KeyCode.LeftArrow, new MenuLeft(mm));
        controlList.Add(KeyCode.UpArrow, new MenuUp(mm));
        controlList.Add(KeyCode.DownArrow, new MenuDown(mm));
        controlList.Add(KeyCode.RightArrow, new MenuRight(mm));
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
