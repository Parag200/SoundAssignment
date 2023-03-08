using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orb : MonoBehaviour
{
    public float life = 3f;
    public GameObject orbPrefab;


    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Orc")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Destroy(orbPrefab);
        }
        

        if (collision.gameObject.tag == "world" || collision.gameObject.tag == "orc")
        {
            Destroy(orbPrefab);
        }
            
    }
}