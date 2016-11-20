using UnityEngine;

public interface IAttribute {
	void ApplyAttribute(PlayerStats stats);
    Color color { get; set; }
}
