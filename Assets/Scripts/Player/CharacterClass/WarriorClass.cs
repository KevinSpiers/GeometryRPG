using UnityEngine;
using System.Collections;

public class WarriorClass : ICharacterClass{

	AbilityManager am { get; set; }
	PlayerStats ps { get; set; }
	public WarriorClass(){ 
		am = new AbilityManager ();
		ps = new PlayerStats (160,50,2,3,1,2);
	}

	void SetAbilities(){
		for (int i = 0; i < am.AbilityLength (); i++) {
			am.SetAbility (null, i);
		}
	}

}
