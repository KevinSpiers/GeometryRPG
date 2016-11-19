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

	public void CoolDown()
	{
		for(int i = 0; i < abilityLength; i++){
			if(ability[i] != null){
				ability[i].AbilityCoolDown.CoolDown();
			}
		}
	}
}
