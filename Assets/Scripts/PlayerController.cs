using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float x;
    float y;
    Manager GM;
    int Mydimmenssion = 0;
    public bool questComplete = false;
    public GameObject QuestCompleteFX;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GM = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        rb.velocity = transform.forward * y*10+transform.right*x*10;

       
        float xx = 5 * Input.GetAxis("Mouse X");
        float yy = 5 * -Input.GetAxis("Mouse Y");
        //this.gameObject.transform.Rotate(00, xx, 0);

        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DimmensionID>())
        {
            if (other.GetComponent<DimmensionID>().ID != this.gameObject.GetComponent<DimmensionID>().ID)
            {
                return;
            }

        }
        
        if (other.gameObject.tag == "NPC")
        {
            if (other.GetComponent<DimmensionID>().ID != this.gameObject.GetComponent<DimmensionID>().ID)
            {
                return;
            }
            other.GetComponent<QuestGiverBehavior>().ShowTalkButton();
            
           
        }
        if (other.gameObject.tag=="Portal")
        {
            
            if(GM.WrongDirection)
            {
                return;
            }

            int NewDimmenssion= other.gameObject.GetComponent<portalBehavior>().id;//nouvelle dimmenssion
            int OldDimmenssion = this.gameObject.GetComponent<DimmensionID>().ID;//ancienne dimmenssion

            this.gameObject.GetComponent<DimmensionID>().ID = NewDimmenssion;//me deplace dans la nouvelle dimmenssion   
            
            if(other.gameObject.GetComponent<portalBehavior>().BothWay)//si on peut revenir dans le meme portail
            {
                other.gameObject.GetComponent<DimmensionID>().ID = NewDimmenssion;//deplace le portail dans ma nouvelle dimmenssion
                other.gameObject.GetComponent<portalBehavior>().id = OldDimmenssion;//Set la destination du portail vers l'ancienne dimmenssion
            }
            

            print("passPortal From "+OldDimmenssion+" TO "+NewDimmenssion);
            GM.passPortal(OldDimmenssion,NewDimmenssion);

        }
        if(other.gameObject.tag=="Item")
        {
            if (other.GetComponent<DimmensionID>().ID != this.gameObject.GetComponent<DimmensionID>().ID)
            {
                return;
            }
            other.GetComponent<ItemBehavior>().ShowE();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            other.GetComponent<QuestGiverBehavior>().HideTalkButton();
        }
        if (other.gameObject.tag == "Item")
        {
            other.GetComponent<ItemBehavior>().HideE();
        }
    }
}
