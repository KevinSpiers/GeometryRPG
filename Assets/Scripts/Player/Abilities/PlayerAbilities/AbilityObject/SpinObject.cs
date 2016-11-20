using UnityEngine;
using System.Collections;

public class SpinObject : MonoBehaviour, IAbilityObject {

	private Player player;

	private Vector2 StartLocation;
	private float MaxDistanceCovered;
	private int Damage;
	private Vector2 vectorFromPlayer;
	private AbilityExpirationTimer timer;

	public void Make(Player _player)
	{
		player = _player;
		StartLocation = player.gameObject.transform.position;
		MaxDistanceCovered = player.characterClass.ps.AttackRange;
		Damage = player.characterClass.ps.Attack;
	}

	// Use this for initialization
	void Start () {
		this.gameObject.transform.position = StartLocation;
		Rigidbody2D rigidbody = this.gameObject.GetComponent<Rigidbody2D> ();
		timer = new AbilityExpirationTimer (2f);
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
		GetComponent<Rigidbody>().transform.Rotate (Vector3.forward*Time.deltaTime);
		this.transform.position = player.transform.position;
		if (timer.shouldDestroy ()) {
			Destroy (this.gameObject);
		}
	}
}
