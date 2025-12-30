 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pullMenu;
    public GameObject gameScreen;
    public GameObject instructionMenu;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Start()
    {
        mainMenu.SetActive(true);
        instructionMenu.SetActive(false);
        gameScreen.SetActive(false);
    }

    public void ToggleMenuState()
    {
        audioManager.PlaySFX(audioManager.menuNav);

        if (mainMenu.activeSelf) {
            mainMenu.SetActive(false);
            gameScreen.SetActive(true);
        } else {
            mainMenu.SetActive(true);
            gameScreen.SetActive(false);
        }        
        
    }

    public void OpenPullMenu()
    {
        audioManager.PlaySFX(audioManager.menuNav);
        pullMenu.SetActive(true);
    }

    public void ClosePullMenu()
    {
        audioManager.PlaySFX(audioManager.menuNav);
        pullMenu.SetActive(false);
    }
}
