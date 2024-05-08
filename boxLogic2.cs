using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxLogic2 : MonoBehaviour
{
    // Singleton
    private static BoxLogic2 _instance;

    // Singleton
    public static BoxLogic2 Instance
    {
        get { return _instance; }
    }

    private Vector3 offset;
    private bool isDragging = false;

    private void Awake()
    {
        // Singleton make sure only 1 exists
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            
            transform.position = new Vector3(newPosition.x, transform.position.y, transform.position.z);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("whiteSpot"))
        {
            SceneManager.LoadScene("Game 2");
        }
    }
}
