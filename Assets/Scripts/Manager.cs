using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public Material[] ShadingsMats;
    void invertRef(Material M)
    {
        int oldValue = M.GetInt("_RefValue");
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
        M.SetInt("_RefValue", newValue);
        
    }
    void InversePortalDir(GameObject go)
    {
       
        go.transform.rotation = Quaternion.Euler(0,180,0);
    }
    public void passPortal(int id)
    {

        for (int i = 0; i < ShadingsMats.Length; i++)
        {
            invertRef(ShadingsMats[i]);
        }
    }
}
