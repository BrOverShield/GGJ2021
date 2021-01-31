using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTriggerBehacior : MonoBehaviour
{
    GameObject[] Spiders;
   
    private void Start()
    {
        Spiders = GameObject.FindGameObjectsWithTag("Spider");
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            foreach (GameObject s in Spiders)
            {
                s.GetComponent<spiderBehavior>().state = 1;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject s in Spiders)
            {
                s.GetComponent<spiderBehavior>().state = 2;
            }
        }
    }
}
