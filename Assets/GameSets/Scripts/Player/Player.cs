using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Player player;

    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    bool isGrounded = false;

    [SerializeField]
    public Transform shotPlace;

    public Rigidbody Rb { get => rb; set => rb = value; }

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
