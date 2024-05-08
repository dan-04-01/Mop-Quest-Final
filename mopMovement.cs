using UnityEngine;
using System.Collections.Generic;

public class MopMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 tileSize = new Vector2(0.5f, 0.5f); 
    public GameObject visitedTilePrefab; 

    
    private Stack<Vector2Int> visitedTilePositions = new Stack<Vector2Int>();

    void Start()
    {
        
        Vector2Int startingTile = GetTilePosition(transform.position);
        visitedTilePositions.Push(startingTile);
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2Int currentTile = GetTilePosition(transform.position);

       
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

        if (movement != Vector2.zero)
        {
            Vector2Int targetTile = currentTile + Vector2Int.RoundToInt(movement);

            
            if (!visitedTilePositions.Contains(targetTile))
            {
                
                Vector2 targetPosition = (Vector2)transform.position + movement * tileSize;
                DrawVisitedTile(transform.position);
                
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

               
                visitedTilePositions.Push(currentTile);

                
            }
        }
    }

    
    private Vector2Int GetTilePosition(Vector3 worldPosition)
    {
        int x = Mathf.FloorToInt((worldPosition.x - tileSize.x / 2) / tileSize.x);
        int y = Mathf.FloorToInt((worldPosition.y - tileSize.y / 2) / tileSize.y);
        return new Vector2Int(x, y);
    }

    
    private void DrawVisitedTile(Vector3 tilePosition)
    {
        
        Instantiate(visitedTilePrefab, tilePosition, Quaternion.identity);
    }
}
