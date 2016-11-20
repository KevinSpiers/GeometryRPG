using UnityEngine;
using System.Collections;

public class BeamObject : MonoBehaviour {

	private Player player;

	private Vector2 StartLocation;
	private Vector2 Direction;
	private float MaxDistanceCovered;
	private int Damage;
	private Vector2 vectorFromPlayer;
	private AbilityExpirationTimer timer;

	public void Make(Player _player)
	{
		player = _player;
		Direction = player.playerState.DirectionToVector();
		StartLocation = (Vector2)player.gameObject.transform.position + Direction;
		MaxDistanceCovered = player.characterClass.ps.AttackRange;
		Damage = player.characterClass.ps.Attack;
	}

	// Use this for initialization
	void Start () {
		this.gameObject.transform.position = StartLocation;
		Rigidbody2D rigidbody = this.gameObject.GetComponent<Rigidbody2D> ();
		float sign = (Vector2.up.x < Direction.x)? -1.0f : 1.0f;
		rigidbody.transform.Rotate (0f,0f,Vector2.Angle(Vector2.up, Direction) * sign);
		timer = new AbilityExpirationTimer (.5f);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.gameObject.GetComponent<IEnemy>() != null){
			coll.gameObject.GetComponent<IEnemy>().TakeDamage(player.characterClass.ps.Attack*5);
		}
	}

	void Update () 
	{
		this.transform.position = player.transform.position + (Vector3)Direction;
		if (timer.shouldDestroy ()) {
			Destroy (this.gameObject);
		}
	}
}
