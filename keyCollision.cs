using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("m"))
        {
            
            if (audioSource != null)
            {
                audioSource.Play();
            }

            
            Invoke("DestroyObjects", audioSource.clip.length);
        }
    }

    void DestroyObjects()
    {
        
        Destroy(gameObject);

       
        GameObject barrier1 = GameObject.Find("barrier1");
        if (barrier1 != null)
        {
            Destroy(barrier1);
        }
        else
        {
            Debug.LogWarning("Barrier1 not found!");
        }

        
        GameObject barrier2 = GameObject.Find("barrier2");
        if (barrier2 != null)
        {
            Destroy(barrier2);
        }
        else
        {
            Debug.LogWarning("Barrier2 not found!");
        }
    }
}
