using UnityEngine;
using System.Collections;

public class WarriorClass : ICharacterClass{

	public AbilityManager am { get; set; }
	public PlayerStats ps { get; set; }
	public WarriorClass(){ 
		am = new AbilityManager ();
		ps = new PlayerStats (160,50,2,3,1,2);
	}

	public void SetAbilities(Player player){
		am.SetAbility (new Stab(player), 0);
		am.SetAbility (new Spin(player), 1);
		am.SetAbility (new WarriorBoost(player), 2);
		am.SetAbility (new Beam(player), 3);

	}

}
