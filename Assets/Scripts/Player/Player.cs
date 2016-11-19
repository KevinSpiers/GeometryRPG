using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public ICharacterClass characterClass;
	public IController controls;

	void Start () 
	{
        Application.runInBackground = true;
		controls = new KeyboardController (this);
    }

	void Update () 
	{
        controls.Execute();
		characterClass.am.CoolDown ();
	}
}
