using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public int sceneBuildIndex;
    public void PlayGame()
    {
        SceneManager.LoadScene("Guide");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
