using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WarriorHealthOption : MonoBehaviour {
	void Start () {}
	void Update () {}
    void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraHealth();
        SceneManager.LoadScene("Main");
    }
}
