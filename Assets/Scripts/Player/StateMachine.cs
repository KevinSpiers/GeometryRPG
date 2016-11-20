using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine  {
	public enum Direction{LEFT, RIGHT, UP, DOWN}
	public Direction dir = Direction.UP;
	Player player;

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

	public StateMachine(Player _player){
		player = _player;
	}

	public void MoveLeft(){
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			HorizontalMovement = Vector2.left * player.characterClass.ps.MovementSpeed;
		}
		dir = Direction.LEFT;
	}

	public void MoveRight(){
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			HorizontalMovement = Vector2.right * player.characterClass.ps.MovementSpeed;
		}
		dir = Direction.RIGHT;
	}

	public void MoveUp(){
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			VerticalMovement = Vector2.up * player.characterClass.ps.MovementSpeed;
		}
		dir = Direction.UP;
	}

	public void MoveDown(){
		if (!Game.GamePaused && player.characterClass.ps.Health > 0) {
			VerticalMovement = Vector2.down * player.characterClass.ps.MovementSpeed;
		}
		dir = Direction.DOWN;
	}

	public void SmoothMoves(){
		Rigidbody2D rigidbody = player.GetComponent<Rigidbody2D>();
		rigidbody.velocity = knockback + verticalMovement + horizontalMovement;
		Vector2.SmoothDamp(knockback, Vector2.zero, ref knockback, 2f);
		Vector2.SmoothDamp(verticalMovement, Vector2.zero, ref verticalMovement, .5f);
		Vector2.SmoothDamp(horizontalMovement, Vector2.zero, ref horizontalMovement, .5f);
		//player.GetComponentInChildren<Animator>().SetInteger("Health", player.stats.Health);
	}

	public Vector2 DirectionToVector(){
		Vector2 vec = new Vector2 ();
		if (dir == StateMachine.Direction.UP) {
			vec = Vector2.up;
		} else if (dir == StateMachine.Direction.DOWN) {
			vec = Vector2.down;
		} else if (dir == StateMachine.Direction.LEFT) {
			vec = Vector2.left;
		} else if (dir == StateMachine.Direction.RIGHT) {
			vec = Vector2.right;
		}
		return vec;
	}

}
