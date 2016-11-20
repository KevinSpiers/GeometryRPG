using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.UI.StartScreen;

public class WarriorGoldOption : MonoBehaviour, IButtonCommand {
    void Start() { }
    void Update() { }
    public void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraGold();
        SceneManager.LoadScene("Main");
    }
}
