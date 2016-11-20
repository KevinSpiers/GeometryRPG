using UnityEngine;
using System.Collections;

public class WarriorHealthOption : MonoBehaviour {
	void Start () {}
	void Update () {}
    void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraHealth();
    }
}
