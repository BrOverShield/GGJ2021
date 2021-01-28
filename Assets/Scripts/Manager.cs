using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void invertRef(GameObject go)
    {

    }
    void InversePortalDir(GameObject go)
    {
       
        go.transform.rotation = Quaternion.Euler(0,180,0);
    }
}
