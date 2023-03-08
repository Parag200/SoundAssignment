using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShoot : MonoBehaviour
{
    public float life = 3f;
    public GameObject firePrefab;
 


    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Orc" || (collision.gameObject.name == "Orc"))
        {
           
            transform.localScale += new Vector3(1, 1, 1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "world")
        {
            Destroy(firePrefab);
        }

    }
}