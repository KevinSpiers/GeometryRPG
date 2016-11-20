using UnityEngine;
using System.Collections;

public class Beam : IAbility {
	private Player player;
	private CoolDownTimer akd;
	public CoolDownTimer AbilityCoolDown
	{ 
		get
		{
			return akd;
		} 
	}

	public Beam(Player _player)
	{
		player = _player;
		akd = new CoolDownTimer (AbilityUtils.BeamCD);
	}

	private void CreateAttack()
	{
		GameObject beam = GameObject.Instantiate(Resources.Load("Prefabs/Beam")) as GameObject;
		BeamObject beamScript = beam.GetComponent<BeamObject>();
		beamScript.Make(player);
	}


	public void UseAbility()
	{
		if (akd.CanUse) {
			CreateAttack();
			akd.StartCoolDown();
		}
	}
}
