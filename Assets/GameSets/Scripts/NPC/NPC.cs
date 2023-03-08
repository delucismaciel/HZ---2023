using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    int life=50, 
        maxLife=50;

    [SerializeField]
    string currentTalk, optAccept, optCancel;

    [SerializeField]
    string npcName;

    [SerializeField]
    GameObject panel;

    public GameObject questPanel;  
    
    public List<Quest> avaliableQuests;
    public bool hasAvaliableQuest=false;

    // Start is called before the first frame update
    void Start()
    {
        currentTalk = "\tOl� aventureiro, j� conseguiu explorar todo o mapa?\n\n\tN�o se esque�a de encontrar a pedra sagrada que te pedi!";
        optAccept = "J� encontrei";
        optCancel = "Ainda n�o";
        npcName = "Jeremias";
    }

    public void Interaction(){
        PainelInteractive painel = Instantiate(panel,UIController.UI.gameObject.transform).GetComponent<PainelInteractive>();
        painel.title.text = npcName;
        painel.content.text = currentTalk;
        painel.txtCancel.text = optCancel;
        painel.txtSubmit.text = optAccept;
        painel.npc = this.GetComponent<NPC>();
    }

}
