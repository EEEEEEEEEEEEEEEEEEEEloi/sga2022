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


    public void HowToPlay()
    {
         StartCoroutine(ShowHowToPlay());
    }
    private IEnumerator ShowHowToPlay()
    {
        GetComponent<AudioSource>().Play();
    yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
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

    public void Credits()
    { 
        StartCoroutine(ShowCredits()); 
    }

    
     private IEnumerator ShowCredits()
            {
                GetComponent<AudioSource>().Play();
    yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
     if(!credits.active){
            credits.SetActive(true);
            foreach(var button in buttons)
            {
                button.interactable = false;
            }
        }else{
            credits.SetActive(false);
            foreach(var button in buttons)
            {
                button.interactable = true;
            }

            }
   
    
        }
       
    }

