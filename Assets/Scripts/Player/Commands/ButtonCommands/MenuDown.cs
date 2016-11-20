using UnityEngine;
using System.Collections;

public class MenuDown : ICommand
{
    public MenuManager mmm;
    public MenuDown(MenuManager mm)
    {
        mmm = mm;
    }
    public void KeyDown()
    {
        //move menu selector right
        mmm.MoveSelectorDown();
    }

    public void KeyHeld()
    {

    }

    public void KeyUp()
    {

    }
}
