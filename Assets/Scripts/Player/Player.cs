using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public ICharacterClass characterClass;
	public IAttribute attr;
	public IController controls;

	void Start () 
	{
        //Application.runInBackground = true;
		characterClass = new WarriorClass();
		attr = new ExtraHealth ();
		controls = new KeyboardController (this);
    }

	void Update () 
	{
        controls.Execute();
		characterClass.am.CoolDown ();
	}
}
