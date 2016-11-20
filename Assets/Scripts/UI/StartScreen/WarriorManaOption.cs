using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.UI.StartScreen;
using System;

public class WarriorManaOption : MonoBehaviour, IButtonCommand {
    void Start() { }
    void Update() { }
    public void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraMana();
        SceneManager.LoadScene("Main");
    }
}
