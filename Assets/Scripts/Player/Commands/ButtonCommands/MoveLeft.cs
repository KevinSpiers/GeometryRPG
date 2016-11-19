using UnityEngine;
using System.Collections;

public class MoveLeft : ICommand {
	Player player;
	Rigidbody2D rigidbody;
    Animator anim;
    KeyboardController controller;
    public MoveLeft(Player _player, KeyboardController _controller)
	{
		player = _player;
		rigidbody = player.GetComponent<Rigidbody2D> ();
        anim = player.GetComponentInChildren<Animator>();
        controller = _controller;
    }

	public void KeyDown()
	{
        if (!Game.GamePaused && player.stats.Health > 0)
        {
            anim.SetBool("Left", true);
        }
	}

	public void KeyHeld()
	{
		if (!Game.GamePaused && player.stats.Health > 0) {
            controller.HorizontalMovement = Vector2.left * player.stats.MoveSpeed;
            anim.SetBool("Left", true);
        }
	}

    public void KeyUp()
    {
        anim.SetBool("Left", false);
    }
}