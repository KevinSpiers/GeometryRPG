using UnityEngine;
using System.Collections;

public class MenuSelect : ICommand {
    public MenuManager mmm;
    public MenuSelect(MenuManager mm)
    {
        mmm = mm;
    }

    public void KeyDown()
    {
        //select current menu option
        mmm.ActivateCurrent();
    }
    
    public void KeyHeld()
    {

    }

    public void KeyUp()
    {

    }

}
