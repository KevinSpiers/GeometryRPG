using UnityEngine;
using System.Collections;

public class ManaPickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<Player> () != null) {
			other.GetComponent<Player> ().characterClass.ps.GainMana (20);
			Destroy (this.gameObject);
		}
	}
}
