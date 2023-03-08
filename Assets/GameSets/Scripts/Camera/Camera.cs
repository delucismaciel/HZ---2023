using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    Player player;

    [SerializeField]
    float smoothTime = 0.25f;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <Player> ();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Vector3.Lerp(transform.position, player.transform.position + new Vector3(0, 3.5f, -3.2f), smoothTime);
        transform.position = v; 
    }
}
