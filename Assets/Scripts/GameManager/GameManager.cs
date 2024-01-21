using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 3f;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON!");
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart Game
            //Restart();
            //Invoke take two peramiters ("name of a function", delay the amount of time before calling a function)
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        //SceneManager.LoadScene("World1-1")
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
