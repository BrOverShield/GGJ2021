using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    //on obtiens une quest en parlais au scientifique
    //la quest est relie a un objet en particulier
    //quand on rapporte l'objet, on termine la quest et on en commence une nouvelle

    
    public int Progressid = 0;
    public int MAxObjectives = 5;
    public bool FocusQuestComplete = false;
    public bool HasQuestActive = false;
    public void QuestImemFound()
    {

    }
    public void QuestComplete()
    {
        FocusQuestComplete = false;
        HasQuestActive = false;
        Progressid++;
    }
    public void GiveQuest()
    {
        if(Progressid<MAxObjectives)
        {
            HasQuestActive = true;
        }
    }
    
}
