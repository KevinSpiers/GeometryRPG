using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour
{
    float elapsedTime = 0f;
    float startTime = 0f;
    float hurtTime = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.GetComponent<Player>() != null)
        {
            startTime = Time.time;
            Player player = other.GetComponent<Player>();
			player.characterClass.ps.LoseHealth (5);
			Debug.Log (player.characterClass.ps.Health);
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
		if (other.GetComponent<Player>() != null)
        {
            elapsedTime = Time.time - startTime;
            if (elapsedTime > hurtTime)
            {
                Player player = other.GetComponent<Player>();
				player.characterClass.ps.LoseHealth (5);
                startTime = Time.time;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
		if (other.GetComponent<Player>() != null)
        {
            elapsedTime = 0;
            startTime = 0;
        }
    }
}
