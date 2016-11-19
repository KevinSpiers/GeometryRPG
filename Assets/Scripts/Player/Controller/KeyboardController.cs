using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyboardController : IController {
	private Dictionary<KeyCode,ICommand> controlList;
	private Player player;

    private Vector2 horizontalMovement = Vector2.zero;
    public Vector2 HorizontalMovement
    {
        get { return horizontalMovement; }
        set { horizontalMovement = value;}
    }
    private Vector2 verticalMovement = Vector2.zero;
    public Vector2 VerticalMovement
    {
        get { return verticalMovement; }
        set { verticalMovement = value; }
    }
    private Vector2 knockback = Vector2.zero;
    public Vector2 Knockback
    {
        get { return knockback; }
        set { knockback = value; }
    }

    public KeyboardController(Player _player)
	{
		controlList = new Dictionary<KeyCode,ICommand> ();
		player = _player;

        controlList.Add (KeyCode.W, new MoveUp (_player, this));
		controlList.Add (KeyCode.A, new MoveLeft (_player, this));
		controlList.Add (KeyCode.S, new MoveDown (_player, this));
		controlList.Add (KeyCode.D, new MoveRight (_player, this));
		controlList.Add (KeyCode.Escape, new OptionsMenu (_player));
		controlList.Add (KeyCode.E, new Interact (_player));
		controlList.Add (KeyCode.F, new FullScreen (_player));
        controlList.Add(KeyCode.LeftArrow, new Ability1(_player));
        controlList.Add(KeyCode.UpArrow, new Ability2(_player));
        controlList.Add(KeyCode.DownArrow, new Ability3(_player));
        controlList.Add(KeyCode.RightArrow, new Ability4(_player));


    }

	public void Execute () 
	{
		foreach (KeyCode key in controlList.Keys) 
		{
			if(Input.GetKeyDown(key))
			{
				ICommand cmd = null;
				controlList.TryGetValue(key,out cmd);
				if(cmd != null)
				{
					cmd.KeyDown();
				}
			}
			if(Input.GetKey(key))
			{
				ICommand cmd = null;
				controlList.TryGetValue(key,out cmd);
				if(cmd != null)
				{
					cmd.KeyHeld();
				}
			}
            if(Input.GetKeyUp(key))
            {
                ICommand cmd = null;
                controlList.TryGetValue(key, out cmd);
                if (cmd != null)
                {
                    cmd.KeyUp();
                }
            }
		}
			
        Rigidbody2D rigidbody = player.GetComponent<Rigidbody2D>();
        rigidbody.velocity = knockback + verticalMovement + horizontalMovement;
        Vector2.SmoothDamp(knockback, Vector2.zero, ref knockback, 2f);
        Vector2.SmoothDamp(verticalMovement, Vector2.zero, ref verticalMovement, .5f);
        Vector2.SmoothDamp(horizontalMovement, Vector2.zero, ref horizontalMovement, .5f);
        //player.GetComponentInChildren<Animator>().SetInteger("Health", player.stats.Health);
    }
}
