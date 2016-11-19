using UnityEngine;
using System.Collections;

public class Fireball : IAbility {
	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer abilityCoolDown
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


	public void UseSkill()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}
	
}
