using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter2D(Collider2D collission)
    {
       if(collission.tag == "Player")
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1)
        //FindObjectOfType<GameManager>().CompleteLevel();
        //gameManager.CompleteLevel();
        }



}
