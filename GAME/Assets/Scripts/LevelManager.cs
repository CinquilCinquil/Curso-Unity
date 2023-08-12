using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(int index) 
    {
        SceneManager.LoadScene(index);
    }

    public void Reloadlevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SetTimeSpeed(float scale)
    {
        Time.timeScale = scale;
    }

    public void QuitGame()
    { 
        Application.Quit();
    }

}
