using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void NextButton()
    {
        LevelManager.levelCount++;
        Debug.Log("aaaa");
        SceneManager.LoadScene(LevelManager.levelCount);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
