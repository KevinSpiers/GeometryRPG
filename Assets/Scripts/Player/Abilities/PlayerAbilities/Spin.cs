using UnityEngine;
using System.Collections;

public class Spin : IAbility {

	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer AbilityCoolDown
	{ 
		get
		{
			return akd;
		} 
	}

	public Spin(Player _player)
	{
		player = _player;
		akd = new CoolDownTimer (AbilityUtils.SpinCD);
	}

	private void CreateAttack()
	{
		GameObject spin = GameObject.Instantiate(Resources.Load("Prefabs/spin")) as GameObject;
		SpinObject spinScript = spin.GetComponent<SpinObject>();
		spinScript.Make(player);
	}


	public void UseAbility()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}

}
