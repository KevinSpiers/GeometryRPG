using UnityEngine;

public class ExtraHealth : IAttribute {
	public void ApplyAttribute(PlayerStats stats){
		stats.GainMaxHealth (30);
	}
    public Color color { get; set; }
    public ExtraHealth()
    {
        color = Color.red;
    }
}
