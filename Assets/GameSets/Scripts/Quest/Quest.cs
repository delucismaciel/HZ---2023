using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Quest", menuName = "Quests/Quest")]
public class Quest : ScriptableObject
{
    public int id;
    public string name;
    public string description;
    public string title;
    public QuestState state;
    public List<Quest> nextQuests;
    public List<ItemQuest> requiredItens;

    public NPC npc;

    public void CompleteQuest()
    {
        if (requiredItens != null)
            foreach (var item in requiredItens)
            {
                //Checar se o player tem todos os itens
            }
        else
        {
            state = QuestState.done;
            //remover a quest do manager e do player list
            foreach(var quest in nextQuests)
            {
                quest.AvaliableQuest();
            }
        }
    }

    public void AvaliableQuest()
    {
        state = QuestState.avaliable;
    }

}

public struct ItemQuest
{
    Item item;
    float qnt;
}

public enum QuestState
{
    unavaliable, avaliable, accepted, progress, done
}
