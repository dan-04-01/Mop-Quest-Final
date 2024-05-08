using UnityEngine;
using UnityEngine.SceneManagement;
public class boxlogic : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("whiteSpot"))
        {
             

            
             
            
                SceneManager.LoadScene("Game 1");
            

            
            
        }
    }
}
