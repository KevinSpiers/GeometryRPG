using UnityEngine;
using System.Collections;

public class AbilityExpirationTimer {
	private float MaxTime{ get; set; }
	private float currentTime{ get; set; }

	public AbilityExpirationTimer(float _maxCoolDownTime)
	{
		MaxTime = _maxCoolDownTime;
		currentTime = _maxCoolDownTime;
	}

	public bool shouldDestroy()
	{
		if (currentTime > 0) {
			currentTime -= Time.deltaTime;
			return false;
		} else {
			return true;
		}
	}
}
