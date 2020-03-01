using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour
{
    private float jumpspeed = 5;
    public Rigidbody rib;


    // Start is called before the first frame update
    void Start()
    {
        rib = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            rib.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
           // onGround = false;

        }
        //void OnCollisionEnter(Collision collision)
       // {
          //  onGround = true;
       // }
    }
}
