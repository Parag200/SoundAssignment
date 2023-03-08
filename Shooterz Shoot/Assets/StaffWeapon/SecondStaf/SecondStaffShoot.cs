using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondStaffShoot : MonoBehaviour
{
    public Transform orbSpawnPoint;
    public Transform orbSpawnPoint2;
    public Transform orbSpawnPoint3;
    public GameObject orbPrefab;
    public float orbSpeed = 35f;
    public ParticleSystem shootOrb;

    public AudioSource aud;
    public AudioClip sht;
  

    //Default to 3 second cooldown
    public float Cooldown = 1.5f;

    //Used as a count down timer
    public float CooldownCountdown = 0f;

    void Update()
    {
        //if the timer has elapsed
        if (CooldownCountdown < 0f)
        {
            if (Input.GetMouseButtonDown(0))
            {

                var bullet = Instantiate(orbPrefab, orbSpawnPoint.position, orbSpawnPoint.rotation);
                var bullet2 = Instantiate(orbPrefab, orbSpawnPoint2.position, orbSpawnPoint2.rotation);
                var bullet3 = Instantiate(orbPrefab, orbSpawnPoint3.position, orbSpawnPoint3.rotation);
                bullet.GetComponent<Rigidbody>().velocity = orbSpawnPoint.forward * orbSpeed;
                bullet2.GetComponent<Rigidbody>().velocity = orbSpawnPoint2.forward * orbSpeed;
                bullet3.GetComponent<Rigidbody>().velocity = orbSpawnPoint3.forward * orbSpeed;
                shootOrb.Play();
                aud.PlayOneShot(sht);

                //reset the cooldown timer
                CooldownCountdown = Cooldown;

            }
        }
         
        else
        {
            //Countdown the timer with the time past in the last frame
            CooldownCountdown -= Time.deltaTime;
            
        }
    }
}
