using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Spike") || collision.gameObject.CompareTag("Block"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
