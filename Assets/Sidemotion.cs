using UnityEngine;
using System.Collections;

public class Sidemotion : MonoBehaviour
{
    public Rigidbody cube;

    public float d = 10f;  // Amount to move left and right from the start point
    public float s = 10f;

    void FixedUpdate()
    {
        cube.AddForce(0, 0, d * Time.deltaTime);

        
        cube.AddForce(s * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
        
        
           // rb.AddForce(-SF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
        
    }
    //private Vector3 startPos;

   // void Start()
   // {
    //    startPos = transform.position;
   // }

   // void Update()
   // {
    //    Vector3 v = startPos;
    //    v.x += delta * Mathf.Sin(Time.time * speed);
    //    transform.position = v;
   // }
}