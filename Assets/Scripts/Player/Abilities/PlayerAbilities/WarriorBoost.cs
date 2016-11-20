using UnityEngine;
using System.Collections;

public class WarriorBoost : IAbility {
	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer AbilityCoolDown
	{ 
		get
		{
			return akd;
		} 
	}

	public WarriorBoost(Player _player)
	{
		player = _player;
		akd = new CoolDownTimer (20f);
	}

	private void CreateAttack()
	{
		GameObject warriorBoost = GameObject.Instantiate(Resources.Load("Prefabs/warriorBoost")) as GameObject;
		WarriorBoostObject warriorBoostScript = warriorBoost.GetComponent<WarriorBoostObject>();
		warriorBoostScript.Make(player);
	}


	public void UseAbility()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}
}
