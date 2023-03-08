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
        if (collision.gameObject.tag == "Orc")
        {
           
            transform.localScale += new Vector3(2, 2,2);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boss")
        {

            Destroy(firePrefab);
        }

        if (collision.gameObject.tag == "world")
        {
            Destroy(firePrefab);
        }

    }
}