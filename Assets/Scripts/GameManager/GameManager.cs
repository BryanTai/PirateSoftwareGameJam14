using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class GameManager : MonoBehaviour
{
    public Text gameOverText;
    public Text winText;

    bool gameHasEnded = false;

    public float restartDelay = 3f;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON!");
        winText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void EndGame()
    {

        if(gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 1;
            //    gameHasEnded = true; 
            //Restart Game
            //Restart();
            //Invoke take two peramiters ("name of a function", delay the amount of time before calling a function)
            //    Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        //SceneManager.LoadScene("World1-1")
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void CurrentRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
