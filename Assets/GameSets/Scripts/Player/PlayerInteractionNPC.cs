using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionNPC : MonoBehaviour
{
    [SerializeField]
    float distance=5;

    [SerializeField]
    List<NPC> interactible = new List<NPC>();

    private void Update()
    {
        if( interactible.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Tentando interagir com um NPC");
                CallInteraction();
            }
            UIController.UI.PressF(true);
        }
        else
            UIController.UI.PressF(false);

    }

    NPC GetNextNPC()
    {
        NPC next = interactible[0];
        float dist=100;
        foreach(NPC npc in interactible)
        {
            if(Vector3.Distance(this.gameObject.transform.position, npc.gameObject.transform.position) < dist){
                dist = Vector3.Distance(this.gameObject.transform.position, npc.gameObject.transform.position);
                next = npc;
            }
        }
        return next;
    }

    void CallInteraction()
    {
        GetNextNPC().Interaction();
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, distance);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("NPC"))
        {
            Gizmos.color = Color.green;
            if (!interactible.Contains(collider.GetComponent<NPC>()))
            {
                interactible.Add(collider.GetComponent<NPC>());
            }
        }
        else
            Gizmos.color = Color.yellow;
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("NPC"))
            if (interactible.Contains(collider.GetComponent<NPC>()))
                interactible.Remove(collider.GetComponent<NPC>());
    }
}
