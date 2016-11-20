using UnityEngine;
using System.Collections;

public class Stab : IAbility {
	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer AbilityCoolDown
	{ 
		get
		{
			return akd;
		} 
	}

	public Stab(Player _player)
	{
		player = _player;
		akd = new CoolDownTimer (.5f);
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
