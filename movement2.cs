using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float moveSpeed = 15f; 

    
    void Update()
    {
        
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;

        
        transform.Translate(movement);
    }
}
