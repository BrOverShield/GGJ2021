using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalBehavior : MonoBehaviour
{
    Manager gm;
    public int id = 0;
    public bool BothWay = true;
    bool ExitTrigStart = false;
    public bool ExitTrig=false;
    float T0 = 0;
    private void Start()
    {
        gm = FindObjectOfType<Manager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(gm.WrongDirection)
        {
            return;
        }
        if (other.tag == "Player")//si on collide avec le enter, on trig le enter et on untrig le exit
        {
            this.transform.GetChild(0).GetComponent<exitPortal>().EnterTrig = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ExitTrigStart = true;
            T0 = 0;
        }
    }
    private void Update()
    {
        if(ExitTrigStart)
        {
            T0 += Time.deltaTime;
            if(T0>0.1f)
            {
                ExitTrig = false;
                ExitTrigStart = false;
                T0 = 0;
            }
        }
    }
}
