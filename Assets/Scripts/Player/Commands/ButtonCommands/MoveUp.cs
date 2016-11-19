using UnityEngine;
using System.Collections;

public class MoveUp : ICommand {
	Player player;
	Rigidbody2D rigidbody;
    Animator anim;
    KeyboardController controller;
    public MoveUp(Player _player, KeyboardController _controller)
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
            anim.SetBool("Up", true);
        }
    }

	public void KeyHeld()
	{
		if (!Game.GamePaused && player.stats.Health > 0) {
            controller.VerticalMovement = Vector2.up * player.stats.MoveSpeed;
            anim.SetBool("Up", true);
        }
	}

    public void KeyUp()
    {
        anim.SetBool("Up", false);
    }
}
