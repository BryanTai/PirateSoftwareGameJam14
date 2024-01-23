using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            Time.timeScale = 1;
            //FindObjectOfType<GameManager>().CompleteLevel();
            //gameManager.CompleteLevel();
        }
    }
}
