using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public Material[] ShadingsMats;
    public GameObject[] portals;
    public GameObject[] Salles;
    int FocusPortalid = 0;
    public bool WrongDirection = false;
    float WringDirectionTimeOut = 0;
    private void Start()
    {
        ResetDimmenssions();
        ActivateSalles();
    }
    private void Update()
    {
        if(WrongDirection)
        {
            WringDirectionTimeOut += Time.deltaTime;
            if(WringDirectionTimeOut>1f)
            {
                WrongDirection = false;
                
            }
        }
        else
        {
            WringDirectionTimeOut = 0;
        }
    }
    void ResetDimmenssions()
    {
        for (int i = 0; i < ShadingsMats.Length; i++)
        {
            Material M = ShadingsMats[i];
            if (M.GetInt("_OriRefValue") == 99)
            {
                M.SetInt("_OriRefValue", 0);
            }
            ShadingsMats[i].SetInt("_RefValue", ShadingsMats[i].GetInt("_OriRefValue"));

        }
    }
    void invertRef(Material M,int from,int to)
    {
        int oldValue = M.GetInt("_RefValue");
        if(M.GetInt("_OriRefValue")==0)
        {
            M.SetInt("_OriRefValue", 99);
        }

        if(oldValue==0)
        {
            
            M.SetInt("_RefValue", M.GetInt("_OriRefValue"));
        }
        else if(oldValue==to)
        {
            
            M.SetInt("_RefValue", 0);
        }
        if(to==0)
        {
            if(oldValue==99)
            {
                M.SetInt("_RefValue", 0);
            }
        }
        
        //print(oldValue+""+ newValue);
        
        
    }
    void InversePortalDir(GameObject go)
    {
       
        go.transform.rotation = Quaternion.Euler(0,180,0);
    }
    public void ActivatePortals()
    {
        for (int i = 0; i < portals.Length; i++)
        {

            if (portals[i].GetComponent<DimmensionID>().ID == FocusPortalid)
            {
                portals[i].SetActive(true);
                print("activating portal " + FocusPortalid);
            }
            else
            {
                portals[i].SetActive(false);
                print("Deactivating portal " + i);
            }
        }
    }
    public void ActivateSalles()
    {
        for (int i = 0; i < Salles.Length; i++)
        {

            if (Salles[i].GetComponent<DimmensionID>().ID == FocusPortalid)
            {
                for (int j = 0; j < Salles[i].transform.childCount; j++)
                {
                    Salles[i].transform.GetChild(j).gameObject.GetComponent<Collider>().enabled = true;
                }
                
                
            }
            else
            {

                for (int j = 0; j < Salles[i].transform.childCount; j++)
                {
                    Salles[i].transform.GetChild(j).gameObject.GetComponent<Collider>().enabled = false;
                }


            }
        }
    }
    public void passPortal(int From,int To)
    {
        //DimmensionID[] idDimmenssionCheck = FindObjectsOfType<DimmensionID>();
        FocusPortalid = To;
        
        for (int i = 0; i < ShadingsMats.Length; i++)
        {
            //inverse seulement ceux qui sont du from et du to en fait
            
            invertRef(ShadingsMats[i],From,To);
        }
    }
}
