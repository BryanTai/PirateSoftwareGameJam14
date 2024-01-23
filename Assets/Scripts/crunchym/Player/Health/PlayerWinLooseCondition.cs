using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerWinLooseCondition : MonoBehaviour
{

    public Text gameOverText;
    public Text winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "winText")
        {
            winText.gameObject.SetActive(true);
        }
    }
}
