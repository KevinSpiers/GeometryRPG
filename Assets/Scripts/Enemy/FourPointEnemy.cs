using UnityEngine;
using System.Collections;
public class FourPointEnemy : MonoBehaviour, IEnemy
{
	
   public int health { get; set; }
   public int atkDmg { get; set; }
	private float maxTime = 3;
	private float time = 3;
	private int direction = 1;
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.GetComponent<Player> () != null) {
			other.gameObject.GetComponent<Player> ().characterClass.ps.LoseHealth (atkDmg - other.gameObject.GetComponent<Player> ().characterClass.ps.Defense);
		}
	}

    void Start()
    {
        health = 25;
        atkDmg = 30;
    }


    void Update()
	{
		if (time > 0) {
			this.transform.position += direction * Vector3.left * 2 * Time.deltaTime;
			time -= Time.deltaTime;
		} else {
			direction *= -1;
			time = maxTime;
		}
	}

    public void TakeDamage(int dam)
    {
        health -= dam;

        if(health < 0)
        {
            Destroy(this.gameObject);
        }
    }
    
}

