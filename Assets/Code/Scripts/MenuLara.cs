using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLara : MonoBehaviour
{
    public void Playgame ()
{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
}

    public void QuitGame ()
{
        Debug.Log("Quit!");
        Application.Quit();
}

    public void ShowMenu ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadMenu ()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("menu");

    }
    public void NextLevel(){
        GetComponent<AudioSource>().Play();
    }
   




}
