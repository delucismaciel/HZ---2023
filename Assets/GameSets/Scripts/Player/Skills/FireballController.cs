using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
    public float speed = 1000;
    public Vector3 direction;

    void DestroyThis()
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if(direction!=null)
            transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Setup(Vector3 dir)
    {
        direction = new Vector3(0, 0, dir.y) ;
        Invoke("DestroyThis", 5);
    }



    private void OnCollisionEnter(Collision collision)
    {
       // DestroyThis();
    }

}
