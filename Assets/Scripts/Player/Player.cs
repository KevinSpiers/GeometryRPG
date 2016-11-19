using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public PlayerStats stats;
	public SkillsManager skills;
	public IController controls;

	void Start () 
	{
        Application.runInBackground = true;
        stats = new PlayerStats ();
		skills = new SkillsManager ();
		controls = new KeyboardController (this);
    }

	void Update () 
	{
        controls.Execute();
        skills.CoolDown ();
	}
}
