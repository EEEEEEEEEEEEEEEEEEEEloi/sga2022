using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int current_level = 1;
    const int MAX_LEVEL = 4;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        current_level++;
    }

    public int GetIndexCurrentLevel()
    {
        return current_level;
    }
}
