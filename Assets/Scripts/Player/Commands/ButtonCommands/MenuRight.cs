using UnityEngine;
using System.Collections;

public class MenuRight : ICommand
{
    public MenuManager mmm;
    public MenuRight(MenuManager mm)
    {
        mmm = mm;
    }
    public void KeyDown()
    {
        //move menu selector right
        mmm.MoveSelectorRight();
    }

    public void KeyHeld()
    {

    }

    public void KeyUp()
    {

    }
}
