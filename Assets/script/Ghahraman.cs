using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghahraman : MonoBehaviour
{
    public bool Ghahraman1;
    public Rigidbody2D rb;
    public float speed = 3;
    private float move ;
    public Vector2 startPos;

    public GameObject Downlimit;
    
    

    void Update()
    {
        
        if(Ghahraman1)
        {
            move = Input.GetAxisRaw("Horizontal");

    
 
        rb.velocity = new Vector2(move*speed,rb.velocity.x);
        }

    }
}