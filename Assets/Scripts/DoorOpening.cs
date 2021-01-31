using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    bool isfocus = false;
    bool doorHasBenOpen = false;
    float T0 = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            isfocus = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isfocus = false;
        }
    }
    private void Update()
    {
        if(doorHasBenOpen)
        {
            if(T0<5)
            {
                T0 += Time.deltaTime;
            }
            
        }
        else
        {
            if (isfocus)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    this.GetComponent<Animator>().SetInteger("DoorState", 1);
                    doorHasBenOpen = true;
                }
            }
        }
        if(T0>1)
        {
            this.GetComponent<Animator>().SetInteger("DoorState", 2);
        }
    }
   
}
