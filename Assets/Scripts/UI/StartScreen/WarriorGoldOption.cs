using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WarriorGoldOption : MonoBehaviour {
    void Start() { }
    void Update() { }
    public void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraGold();
        SceneManager.LoadScene("Main");
    }
}
