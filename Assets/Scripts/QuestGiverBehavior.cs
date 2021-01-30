using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiverBehavior : MonoBehaviour
{
    public GameObject TalkButton;
    public GameObject QuestCard;
    bool IsFocus = false;
    PlayerController player;
    float CarTimeOff = 0;
    public GameObject QuestCompleteFx;
    public GameObject ItemShow;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    public void ShowTalkButton()
    {
        TalkButton.SetActive(true);
        IsFocus = true;
    }
    public void HideTalkButton()
    {
        TalkButton.SetActive(false);
        IsFocus = false;
    }
    private void Update()
    {
        if(IsFocus)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(player.questComplete==false)
                {
                    giveQuest();
                }
                else
                {
                    Instantiate(QuestCompleteFx, this.transform.position, Quaternion.identity);
                    ItemShow.SetActive(true);
                    this.GetComponent<Animator>().enabled = false;
                }
                
            }
            
            
        }
        if(CarTimeOff<5f)
        {
            CarTimeOff += Time.deltaTime;
        }
        if(CarTimeOff>5f)
        {
            QuestCard.SetActive(false);
        }

    }
    void giveQuest()
    {
        CarTimeOff = 0f;
        QuestCard.SetActive(true);
    }
}
