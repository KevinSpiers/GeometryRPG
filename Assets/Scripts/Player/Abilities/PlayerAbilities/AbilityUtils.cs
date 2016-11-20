public static class AbilityUtils {
	public static float SpinCD = 3f;
	public static float StabCD = .5f;
	public static float BeamCD = 30f;
	public static float WarriorBoostCD = 20f;
	public static float getAbilityCooldown(IAbility ability){
		float num = 1f;
		if (ability is Spin) {
			num = SpinCD;
		} else if (ability is Stab) {
			num = StabCD;
		} else if (ability is Beam) {
			num = BeamCD;
		} else if (ability is WarriorBoost) {
			num = WarriorBoostCD;
		}
		return num;

	}
}
