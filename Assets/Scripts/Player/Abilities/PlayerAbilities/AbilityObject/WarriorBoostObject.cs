using UnityEngine;
using System.Collections;

public class WarriorBoostObject : MonoBehaviour {

	private Player player;

	private Vector2 StartLocation;
	private Vector2 vectorFromPlayer;
	private AbilityExpirationTimer timer;

	public void Make(Player _player)
	{
		player = _player;
		StartLocation = player.gameObject.transform.position;
		_player.characterClass.ps.GainAttackDamage (2);
		_player.characterClass.ps.LoseDefense (1);
	}

	// Use this for initialization
	void Start () {
		this.gameObject.transform.position = StartLocation;
		timer = new AbilityExpirationTimer (5f);
	}

	void Update () 
	{
		this.transform.position = player.transform.position;
		if (timer.shouldDestroy ()) {
			player.characterClass.ps.LoseAttackDamage (2);
			player.characterClass.ps.GainDefense (1);
			Destroy (this.gameObject);
		}
	}
}
