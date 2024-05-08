using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuHandler : MonoBehaviour
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

    public void Options(){
        SceneManager.LoadScene("options");
    }

    public void About(){
        SceneManager.LoadScene("about");
    }

    public void Quit(){
        Application.Quit();
    }
}
