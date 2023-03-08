using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform orbSpawnPoint;
    public GameObject orbPrefab;
    public float orbSpeed = 35f;
    public ParticleSystem shootOrb;

    public AudioSource aud;
    public AudioClip Bolt;
   

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             var bullet = Instantiate(orbPrefab, orbSpawnPoint.position, orbSpawnPoint.rotation);
             bullet.GetComponent<Rigidbody>().velocity = orbSpawnPoint.forward * orbSpeed;
             shootOrb.Play();
             aud.PlayOneShot(Bolt);
            


        }
    }

   
}