using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShot : MonoBehaviour
{
    public Transform FireSpawnPoint;
    public GameObject FirePrefab;
    public float FireSpeed = 35f;
    public ParticleSystem shootFire;

    public AudioSource aud;
    public AudioClip fireSpark;
    public AudioClip fireCir;

    

    //Default to 3 second cooldown
    public float Cooldown = 15.0f;

    //Used as a count down timer
    public float CooldownCountdown = 0f;

    

    void Update()
    {
        if (CooldownCountdown < 0f)
        {
           if (Input.GetKeyDown(KeyCode.E))
            //if (Input.GetKeyDown(KeyCode.K))
            {
               
                    var bullet = Instantiate(FirePrefab, FireSpawnPoint.position, FireSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody>().velocity = FireSpawnPoint.forward * FireSpeed;
                    shootFire.Play();
                    CooldownCountdown = Cooldown;
                    aud.PlayOneShot(fireSpark);
                    aud.PlayOneShot(fireCir);
                   
                   
                
               
            }
        }

        else
        {
            //Countdown the timer with the time past in the last frame
            CooldownCountdown -= Time.deltaTime;

        }
    }
}
