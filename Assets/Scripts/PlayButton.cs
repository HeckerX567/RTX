using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void JoinTheGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitFromGame()
    {
        Application.Quit();
    }

    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
