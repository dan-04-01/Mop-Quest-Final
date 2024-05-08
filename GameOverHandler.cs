using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverHandler : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Play(){
        SceneManager.LoadScene("Game");
    }

    public void Quit(){
        Application.Quit();
    }
}
