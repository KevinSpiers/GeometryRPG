using UnityEngine;
using System.Collections;

public class StabObject : MonoBehaviour, IAbilityObject {

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
		Debug.DrawRay (this.gameObject.transform.position,Direction);
		float sign = (Vector2.up.x < Direction.x)? -1.0f : 1.0f;
		rigidbody.transform.Rotate (0f,0f,Vector2.Angle(Vector2.up, Direction) * sign);
		timer = new AbilityExpirationTimer (.3f);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		//Debug.Log(coll.gameObject.tag);
		/*if (!coll.gameObject.CompareTag ("Player") && !coll.gameObject.CompareTag("Drop") && !coll.gameObject.CompareTag("Attack")) {
			if(coll.gameObject.CompareTag("Enemy")){
				coll.gameObject.GetComponent<IEnemy>().EnemyProp.stats.LoseHealth(Damage);
			}
			Destroy(this.gameObject);
		}*/
	}

	void Update () 
	{
		this.transform.position = player.transform.position + (Vector3)Direction;
		if (timer.shouldDestroy ()) {
			Destroy (this.gameObject);
		}
	}
}
