using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameObject E;
    bool isFocus = false;
    PlayerController player;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    public void ShowE()
   {
        E.SetActive(true);
        isFocus = true;
   }
    public void HideE()
    {
        E.SetActive(false);
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
        this.gameObject.SetActive(false);
    }
}
