using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public float speed = 4f;
    Rigidbody rig;
    public GameObject go;
    public float orcLife;
    

    void Start()
    {
        rig = GetComponent<Rigidbody>();

        
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }


    
}
