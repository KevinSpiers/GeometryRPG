using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScreenManager : MonoBehaviour {
    MenuManager mm;
    IController mc;
    public Button[] buttons;
    public Button b1;
    
	// Use this for initialization
	void Start () {
        //b1 = GameObject.Find("WarriorHealth").GetComponent<Button>();
        
        //create menu manager and add buttons
        mm = new MenuManager(3, 3, 0, 0, buttons[0]);
        //mm = new MenuManager(3, 3, 0, 0, b1);

        //set controller to menu controller
        mc = new MenuController(mm);

        mm.SetButton(0, 1, buttons[1]);
        mm.SetButton(0, 2, buttons[2]);
	}
	
	// Update is called once per frame
	void Update () {
        mc.Execute();
	}
}
