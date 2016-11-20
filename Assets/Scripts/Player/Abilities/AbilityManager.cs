using UnityEngine;
using System.Collections;

public class AbilityManager {

	private static int abilityLength = 4;

	private IAbility[] ability = new IAbility[abilityLength];

	public int AbilityLength(){
		return abilityLength;
	}

	public void SetAbility(IAbility _skill, int _position)
	{
		if (_position >= 0 && _position < abilityLength) {
			ability[_position] = _skill;
		}
	}

	public void UseAbility(int _position)
	{
		if (_position >= 0 && _position < abilityLength) {
			ability [_position].UseAbility ();
		}
	}

	public void CoolDown()
	{
		for(int i = 0; i < abilityLength; i++){
			if(ability[i] != null){
				ability[i].AbilityCoolDown.CoolDown();
				if (!ability [i].AbilityCoolDown.CanUse) {
					int j = i + 1;
					Animator anim = GameObject.Find ("Ability" + j).GetComponent<Animator> ();
					if (!anim.GetBool ("isInCooldown")) {
						anim.SetBool ("isInCooldown", true);
						anim.speed = (17.0f/60)/AbilityUtils.getAbilityCooldown (ability [i]);
					}
				} else {
					int j = i + 1;
					Animator anim = GameObject.Find ("Ability" + j).GetComponent<Animator> ();
					anim.SetBool ("isInCooldown", false);
				}
			}
		}
	}
}
