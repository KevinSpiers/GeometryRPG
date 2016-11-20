using UnityEngine;
using System.Collections;

public class MenuLeft : ICommand
{
    public MenuManager mmm;
    public MenuLeft(MenuManager mm)
    {
        mmm = mm;
    }
    public void KeyDown()
    {
        //move menu selector right
        mmm.MoveSelectorLeft();
    }

    public void KeyHeld()
    {

    }

    public void KeyUp()
    {

    }
}
