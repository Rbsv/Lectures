using System;
using UnityEngine;

public class CubePhysics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb => GetComponent<Rigidbody>();
    [SerializeField]
    private float force;
    [SerializeField]
    private float Velocity;
    
    void Start()
    {
        
    }

    void AddForce()
    {
        rb.AddForce(Vector3.up * force);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))// mouse click event 0 for left 1 - right
        {
            Debug.Log("Mouse left click");
            AddForce();
        }
        if (Input.GetKeyDown(KeyCode.Space)) //only gets executed when pressed first and will give false untill we release and reclick. ( needs to have on button release)
        {
            //invoked only once
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 5, rb.linearVelocity.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space clicked");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space is pressed");
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space Released");
        }
    }

    private void FixedUpdate() // 
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal")*Velocity, rb.linearVelocity.y,Input.GetAxis("Vertical")*Velocity);
       

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //will get invoke when i released the space key on keyboard (allready pressed state).
        }
    }
}
