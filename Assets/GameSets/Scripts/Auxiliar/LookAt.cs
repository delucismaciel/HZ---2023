using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    [SerializeField]
    Transform obj;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(new Vector3(obj.position.x,this.transform.position.y,obj.position.z));
        this.transform.Rotate(new Vector3(0,180,0));
    }
}
