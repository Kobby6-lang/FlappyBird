using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMainMenu : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync("FlappyBird");
    }

    public void QuitGame() 
    {
        SceneManager.LoadScene("Portfolio");
    } 
}
