using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] Groups;
    void invertRef(GameObject go)
    {
        int oldValue = go.GetComponent<Renderer>().material.GetInt("_RefValue");
        int newValue=0;
        if (oldValue == 1)
        {
            newValue = 0;
        }
        else
        {
            newValue = 1;
        }
        //print(oldValue+""+ newValue);
        go.GetComponent<Renderer>().material.SetInt("_RefValue", newValue);
        
    }
    void InversePortalDir(GameObject go)
    {
       
        go.transform.rotation = Quaternion.Euler(0,180,0);
    }
    public void passPortal(int id)
    {
        for (int i = 0; i < Groups[id].transform.childCount; i++)
        {
            if(id==0)
            {
                for (int j = 0; j < 2; j++)
                {
                    invertRef(Groups[id].transform.GetChild(i).transform.GetChild(j).gameObject);
                }
            }
        }
    }
}
