using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitPortal : MonoBehaviour
{
    public bool EnterTrig = false;
    Manager Gm;
    
    private void Start()
    {
        Gm = FindObjectOfType<Manager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(EnterTrig)
        {
            if (other.tag == "Player")//si on cillide avec l<exit on trig l<exit et on UnTrig le enter
            {
                this.transform.parent.GetComponent<portalBehavior>().ExitTrig = true;
                Gm.ActivatePortals();
                EnterTrig = false;
            }
        }
        else
        {
            Gm.WrongDirection = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            EnterTrig = false;
        }
    }
    
}
