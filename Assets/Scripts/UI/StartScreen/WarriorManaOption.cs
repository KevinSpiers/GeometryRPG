using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WarriorManaOption : MonoBehaviour {
    void Start() { }
    void Update() { }
    void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraMana();
        SceneManager.LoadScene("Main");
    }
}
