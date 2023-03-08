using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapStaffs : MonoBehaviour
{

    public GameObject slot1;
    public GameObject slot2;

    

    // Start is called before the first frame update
    void Start()
    {
        slot1.SetActive(true);
        slot2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            slot1.SetActive(true);
            slot2.SetActive(false);
        }

        else if (Input.GetKey("2"))
        {
            slot1.SetActive(false);
            slot2.SetActive(true);
        }
    }
}
