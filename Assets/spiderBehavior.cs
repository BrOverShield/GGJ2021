using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderBehavior : MonoBehaviour
{
    public int state=0;//0=idle,1=walk toward player,2=walk start,3=attack
    int lastState = 0;
    Vector3 startPosition;
    PlayerController Player;
    public float frac=0;
    private void Start()
    {
        startPosition = this.transform.position;
        Player = FindObjectOfType<PlayerController>();
    }
    private void Update()
    {
        if(state!=lastState)
        {
            frac = 0;
            if(state==0)
            {
               // this.GetComponent<Animation>().CrossFade("Idle");
                lastState = 0;
            }
            if (state == 1||state==2)
            {
                //this.GetComponent<Animation>().CrossFade("Walk");
                lastState = state;
            }
        }
        if(state==1)
        {
            frac += 0.1f*Time.deltaTime;
            this.transform.LookAt(Player.gameObject.transform);
            
            this.transform.position= Vector3.MoveTowards(this.transform.position,Player.gameObject.transform.position,frac);
        }
        if(state==2)
        {
            frac += 0.1f * Time.deltaTime;
            this.transform.LookAt(startPosition);

            this.transform.position = Vector3.MoveTowards(this.transform.position, startPosition, frac);
        }
    }
}
