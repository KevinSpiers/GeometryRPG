using UnityEngine;
using System.Collections;

public class MoveRight : ICommand {
	Player player;
	Rigidbody2D rigidbody;
    Animator anim;
    KeyboardController controller;
    public MoveRight(Player _player, KeyboardController _controller)
	{
		player = _player;
		rigidbody = player.GetComponent<Rigidbody2D> ();
        anim = player.GetComponentInChildren<Animator>();
        controller = _controller;
    }

	public void KeyDown()
	{

    }

	public void KeyHeld()
	{
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
            controller.HorizontalMovement = Vector2.right * player.characterClass.ps.MovementSpeed;
            anim.SetBool("Right", true);
        }
	}

    public void KeyUp()
    {
		
    }
}
