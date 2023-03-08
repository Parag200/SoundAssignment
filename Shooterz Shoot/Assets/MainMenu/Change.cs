using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{

    public GameObject bgMusic;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
    }

    public void play()
    {
        SceneManager.LoadScene("Game");
        Destroy(bgMusic);
       
    }

    public void control()
    {
        SceneManager.LoadScene("Controls");
    }

    public void about()
    {
        SceneManager.LoadScene("About");
    }

    public void exit()
    {
        Application.Quit();
    }

    public void menuBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
