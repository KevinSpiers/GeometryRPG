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

    }

	public void KeyHeld()
	{
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			controller.VerticalMovement = Vector2.up * player.characterClass.ps.MovementSpeed;
        }
	}

    public void KeyUp()
    {

    }
}
