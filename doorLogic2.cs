using UnityEngine;
using UnityEngine.SceneManagement;
public class doorLogic2 : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("m"))
        {
             

            
             
            
                SceneManager.LoadScene("level2Done");
            

            
            
        }
    }
}

