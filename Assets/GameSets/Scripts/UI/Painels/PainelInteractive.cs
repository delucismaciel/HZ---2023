using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PainelInteractive : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI title, content, txtSubmit, txtCancel;

    [SerializeField]
    public Button btnSubmit, btnCancel;

    public NPC npc;

    public void Close()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        if (Vector3.Distance(Player.player.transform.position, npc.gameObject.transform.position) > 7)
        {
            Close();
        }
    }


}
