using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoiceonLoad : MonoBehaviour
{
    public AudioSource aud;
    public AudioClip Gotyou;
    // Start is called before the first frame update
    private void Awake()
    {
        aud.PlayOneShot(Gotyou);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
