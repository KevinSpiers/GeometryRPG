using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public ICharacterClass characterClass;
	public IAttribute attr;
	public IController controls;
	public StateMachine playerState;
    //SpriteRenderer renderer;
	void Start () 
	{
        //Application.runInBackground = true;
        characterClass = PlayerUtils.characterClass;
		characterClass.SetAbilities (this);
		attr = PlayerUtils.attribute;
        
        if(attr.color == Color.red)
        {
            //use red sprite
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("RedSquare");
        }
        else if(attr.color == Color.yellow)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("YellowSquare");

        }
        else if(attr.color == Color.blue){
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BlueSquare");
        }
        
        //renderer = gameObject.GetComponent<SpriteRenderer>();
        //renderer.color = attr.color;

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
