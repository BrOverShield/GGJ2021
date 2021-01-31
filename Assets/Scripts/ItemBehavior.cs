using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    QuestManager QM;
    public GameObject E;
    bool isFocus = false;
    PlayerController player;
    public int QuestId=0;
    AudioClip FoundSound;
    //public GameObject EToPickup;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        QM = FindObjectOfType<QuestManager>();
    }
    public void ShowE()
   {
        if(QM.Progressid==QuestId&&QM.HasQuestActive)
        {
            if (E != null)
            {
                E.SetActive(true);
            }
            if(FoundSound!=null)
            {
                
            }
            isFocus = true;
        }
       
   }
    public void HideE()
    {
        if(E!=null)
        {
            E.SetActive(false);
        }
       
        isFocus = false;
    }
    private void Update()
    {
        if(isFocus)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickup();
            }
        }
    }
    void pickup()
    {
        player.questComplete = true;
        QM.FocusQuestComplete = true;
        this.gameObject.SetActive(false);
        if(E!=null)
        {
            QM.FocusQuestComplete = true;
            E.SetActive(false);
        }
       
    }
}
