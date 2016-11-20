using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public ICharacterClass characterClass;
	public IAttribute attr;
	public IController controls;
	public StateMachine playerState;
	void Start () 
	{
        //Application.runInBackground = true;
        characterClass = PlayerUtils.characterClass;
		attr = new ExtraHealth ();
		controls = new KeyboardController (this);
		playerState = new StateMachine (this);
    }

	void Update () 
	{
		playerState.SmoothMoves ();
        controls.Execute();
		characterClass.am.CoolDown ();
	}
}
