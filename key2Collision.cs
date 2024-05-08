using UnityEngine;

public class key2Collision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("m"))
        {
            
            Destroy(gameObject);

            
            GameObject barrier = GameObject.Find("barrier3");
            if (barrier != null)
            {
                Destroy(barrier);
            }
            else
            {
                Debug.LogWarning("Barrier3 not found!");
            }
        }
    }
}
