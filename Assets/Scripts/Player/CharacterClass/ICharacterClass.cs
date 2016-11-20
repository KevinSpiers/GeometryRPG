public interface ICharacterClass
{
    AbilityManager am { get; set; }
	PlayerStats ps { get; set;}
    void SetAbilities(Player player);
}
