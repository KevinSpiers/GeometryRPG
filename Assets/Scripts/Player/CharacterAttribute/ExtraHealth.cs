public class ExtraHealth : IAttribute {
	public void ApplyAttribute(PlayerStats stats){
		stats.GainMaxHealth (30);
	}
}
