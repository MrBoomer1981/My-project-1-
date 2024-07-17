using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class GoHero : MonoBehaviour  
{  

    public Rigidbody rbody;

    public float acceleration;
    public float maxSpeed;

  
    void FixedUpdate()  
    {  
        Vector3 directionForward = rbody.transform.forward * Input.GetAxis("Vertical");  
        Vector3 directionRight = rbody.transform.right * Input.GetAxis("Horizontal");  
      


        Vector3 rusultForceFB = directionForward * acceleration;  
        Vector3 resultForceRL = directionRight * acceleration;  

        if (rbody.velocity.magnitude< maxSpeed)
            rbody.AddForce(rusultForceFB + resultForceRL , ForceMode.Acceleration);
        Debug.Log(rbody.velocity);


        

    }  
}