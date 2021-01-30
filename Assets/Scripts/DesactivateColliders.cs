using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateColliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (this.transform.GetChild(i).transform.GetChild(j).GetComponent<Collider>())
                {
                    this.transform.GetChild(i).transform.GetChild(j).GetComponent<Collider>().isTrigger = true;
                }
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
