using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyboardController : IController {
	private Dictionary<KeyCode,ICommand> controlList;
	private Player player;

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
    }
}
