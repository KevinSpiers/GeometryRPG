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
		akd = new CoolDownTimer (AbilityUtils.StabCD);
    }
	
	private void CreateAttack()
	{
		GameObject sword = GameObject.Instantiate(Resources.Load("Prefabs/sword")) as GameObject;
		StabObject swordScript = sword.GetComponent<StabObject>();
		swordScript.Make(player);
	}


	public void UseAbility()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}
	
}
