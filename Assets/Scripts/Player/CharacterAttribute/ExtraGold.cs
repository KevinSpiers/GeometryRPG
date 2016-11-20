using UnityEngine;

public class ExtraGold : IAttribute {
	public void ApplyAttribute(PlayerStats stats){
		//TODO: Add gold
	}
    public Color color { get; set; }
    public ExtraGold()
    {
        color = Color.yellow;
    }
}
