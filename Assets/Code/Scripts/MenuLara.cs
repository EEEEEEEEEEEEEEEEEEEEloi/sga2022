using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLara : MonoBehaviour
{
    public void Playgame ()
{
      StartCoroutine(LoadSceneGame());
         
}

private IEnumerator LoadSceneGame()
{
    GetComponent<AudioSource>().Play();
      yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         
}

    public void Quit ()
{
       StartCoroutine(QuitGame());
         
}
private IEnumerator QuitGame()
{
GetComponent<AudioSource>().Play();
    yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
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
    public void NextLevel()
    {
        GetComponent<AudioSource>().Play();
    }
   




}
