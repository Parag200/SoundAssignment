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
    public float BossorcLife = 8f;
    

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Orb")
        {
            BossorcLife = BossorcLife - 1;

            if (BossorcLife == 0)
            {
                Destroy(go);
                SceneManager.LoadScene("Victory");
                Debug.Log("YAY");
            }
            
          
        }
    }


}
