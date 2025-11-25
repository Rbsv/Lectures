using System;
using UnityEngine;

public class SquareCollisionScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) // 3d
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(" Collision Happened With: "+other.gameObject.name);
    }
}
