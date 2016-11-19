using UnityEngine;
using System.Collections;

public class WarriorClass : ICharacterClass{

	public AbilityManager am { get; set; }
	public PlayerStats ps { get; set; }
	public WarriorClass(){ 
		am = new AbilityManager ();
		ps = new PlayerStats (160,50,2,3,1,2);
	}

	public void SetAbilities(){
		for (int i = 0; i < am.AbilityLength (); i++) {
			am.SetAbility (null, i);
		}
	}

}
