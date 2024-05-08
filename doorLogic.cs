using UnityEngine;
using UnityEngine.SceneManagement;
public class doorLogic : MonoBehaviour
{
    // This function is called when another collider enters the trigger collider attached to this GameObject.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a tag "Mysterio".
        if (collision.gameObject.CompareTag("m"))
        {
             

            
             
            
                SceneManager.LoadScene("level1Done");
            

            
            
        }
    }
}

