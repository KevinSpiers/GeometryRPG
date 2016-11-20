using UnityEngine;

public class ExtraMana : IAttribute {
	public void ApplyAttribute(PlayerStats stats){
		stats.GainMaxMana (30);
	}
    
    public Color color { get; set; }
    public ExtraMana(){
        color = Color.blue;
    }
}
