using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    
    public float moveSpeed = 2f;

    
    public float amplitude = 2f;

    
    void Update()
    {
        
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        
        Vector3 movement = new Vector3(0f, verticalMovement, 0f) * Time.deltaTime;

        
        transform.Translate(movement);
    }
}
