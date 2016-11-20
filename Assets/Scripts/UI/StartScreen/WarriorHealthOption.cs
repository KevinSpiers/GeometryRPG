using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.UI.StartScreen;
using System;

public class WarriorHealthOption : MonoBehaviour, IButtonCommand{
	void Start () {}
	void Update () {}

    public void Activate()
    {
        PlayerUtils.characterClass = new WarriorClass();
        PlayerUtils.attribute = new ExtraHealth();
        SceneManager.LoadScene("Main");
    }
}
