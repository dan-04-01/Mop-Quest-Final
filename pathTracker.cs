using UnityEngine;

public class pathTracker : MonoBehaviour
{
    public LineRenderer pathRenderer;
    public float pointSpacing = 0.1f; 
    private Vector3 lastPosition;
    private float distanceTravelled = 0f;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        
        float distanceMoved = Vector3.Distance(transform.position, lastPosition);
        
        
        if (distanceMoved >= pointSpacing)
        {
           
            pathRenderer.positionCount++;
            pathRenderer.SetPosition(pathRenderer.positionCount - 1, transform.position);

            
            distanceTravelled += distanceMoved;
            lastPosition = transform.position;
        }
    }
}
