 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DontDestroySong : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private static DontDestroySong instance = null;
    public static DontDestroySong Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game"))
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}

