using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
    }

    public AudioSource aud;
    public AudioClip hover;
    public AudioClip click;

    public void Hover()
    {
        aud.PlayOneShot(hover);
    }

    public void clickSound()
    {
        aud.PlayOneShot(click);
    }


}
