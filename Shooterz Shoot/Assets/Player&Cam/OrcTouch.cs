using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrcTouch : MonoBehaviour
{

    public AudioSource aud;
    public GameObject orcsTwo;
    
   

  
    public AudioClip horn;



   
    // Start is called before the first frame update
    void Start()
    {
        aud.PlayOneShot(horn);
 
        orcsTwo.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Orc").Length < 3)
        {
            aud.PlayOneShot(horn);
            spawnTwo();

            
                
           
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Orc" || other.tag == "Boss")
        {
            Debug.Log("the object was " + other.gameObject.name);
            SceneManager.LoadScene("Lose");
            
        }
    }

    void spawnTwo()
    {
        orcsTwo.SetActive(true);
    }

    
    

}
