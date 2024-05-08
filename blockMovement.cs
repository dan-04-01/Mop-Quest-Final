using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    
    public float moveSpeed = 2f;

   
    public float moveDistance = 2f;

    
    private int moveDirection = 1; 

    
    private Vector3 startPos;

    void Start()
    {
        
        startPos = transform.position;
    }

    
    void Update()
    {
       
        float distance = moveDirection * moveSpeed * Time.deltaTime;

        
        transform.Translate(Vector3.right * distance);

       
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
        {
            
            moveDirection *= -1;

            
            startPos = transform.position;
        }
    }
}
