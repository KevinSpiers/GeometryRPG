using UnityEngine;
using System.Collections;

public class HeartPickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<Player> () != null) {
			other.GetComponent<Player> ().characterClass.ps.GainHealth (20);
			Destroy (this.gameObject);
		}
	}
}
