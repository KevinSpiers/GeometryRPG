public class ExtraMana : IAttribute {
	public void ApplyAttribute(PlayerStats stats){
		stats.GainMaxMana (30);
	}
}
