using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrcTouch : MonoBehaviour
{

    public AudioSource aud;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Orc").Length == 0)
        {
           
            SceneManager.LoadScene("Victory");
            Debug.Log("YAY");
           
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Orc")
        {
            Debug.Log("the object was " + other.gameObject.name);
            SceneManager.LoadScene("Lose");
            
        }
    }
}
