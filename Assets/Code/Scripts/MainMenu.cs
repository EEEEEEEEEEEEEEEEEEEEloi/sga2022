using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject howToPlay;
    [SerializeField]
    private GameObject credits;
    [SerializeField]
    List<Button> buttons;


    public void ShowHowToPlay()
    {
        mainMenu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
        credits.SetActive(false);

        foreach (var button in buttons)
        {
            button.interactable = true;
        }
    }

    public void ShowCredits()
    {
        credits.SetActive(true);
        foreach(var button in buttons)
        {
            button.interactable = false;
        }
    }
}
