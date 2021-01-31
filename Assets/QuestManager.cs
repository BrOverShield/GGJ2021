using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuestManager : MonoBehaviour
{
    //on obtiens une quest en parlais au scientifique
    //la quest est relie a un objet en particulier
    //quand on rapporte l'objet, on termine la quest et on en commence une nouvelle

    
    public int Progressid = 0;

    public bool FocusQuestComplete = false;
    public bool HasQuestActive = false;
    public Texture[] ObjectsDrawings;
    public GameObject PlayerPaper;
    public AudioClip QuestCompleteClip;
    public GameObject TextPlayer;
    public void QuestImemFound()
    {

    }
    public void QuestComplete()
    {
        
        FocusQuestComplete = false;
        HasQuestActive = false;
        Progressid++;
        
        
        TextPlayer.GetComponent<TextMesh>().text = Progressid.ToString() + "/" + ObjectsDrawings.Length.ToString();
    }
    public void GiveQuest()
    {
        if(Progressid<ObjectsDrawings.Length)
        {
            TextPlayer.GetComponent<TextMesh>().text = Progressid.ToString() + "/" + ObjectsDrawings.Length.ToString();
            HasQuestActive = true;
            PlayerPaper.GetComponent<Material>().SetTexture("Albedo",ObjectsDrawings[Progressid]);
        }
        else
        {
            SceneManager.LoadScene("Credits");
        }
    }
    
}
