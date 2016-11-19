using UnityEngine;
using System.Collections;

public class Fireball : IAbility {
	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer AbilityCoolDown
	{ 
		get
		{
			return akd;
		} 
	}

	public Fireball(Player _player)
	{
		player = _player;
		akd = new CoolDownTimer (5);
    }
	
	private void CreateAttack()
	{
		
	}


	public void UseAbility()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}
	
}
