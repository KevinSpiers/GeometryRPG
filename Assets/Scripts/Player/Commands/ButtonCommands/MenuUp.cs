using UnityEngine;
using System.Collections;

public class MenuUp : ICommand {
    public MenuManager mmm;
    public MenuUp(MenuManager mm)
    {
        mmm = mm;
    }
    public void KeyDown()
    {
        //move menu selector right
        mmm.MoveSelectorUp();
    }

    public void KeyHeld()
    {

    }

    public void KeyUp()
    {

    }
}
