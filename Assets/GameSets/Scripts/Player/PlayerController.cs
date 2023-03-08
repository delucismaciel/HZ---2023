using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Vector3 move;

    [SerializeField]
    float speed = 2, jumpForce=500;

    [SerializeField]
    Player player;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <Player> ();
    }

    // Start is called before the first frame update
    void Start()
    {
        move = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Jump()
    {
        Debug.DrawRay(player.transform.position, Vector3.down * 0.9f, Color.red, 0.05f);
        if (Physics.Raycast(player.transform.position, Vector3.down, 0.9f)){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.Rb.velocity += new Vector3(0,jumpForce);
                Debug.Log("Pulou");
            }
        }
    }


    void Move()
    {
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");

        player.transform.Rotate(0, move.x, 0);
        //player.transform.Translate(player.transform.forward * move.y * speed * Time.deltaTime);
        player.Rb.velocity = player.transform.forward * move.z * speed * Time.deltaTime;
    }
}
