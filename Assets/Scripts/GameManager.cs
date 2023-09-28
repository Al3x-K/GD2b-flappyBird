using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.ScreenManager;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startButton;
    public Player player;
    public TMP_Text gameOverCountdown;
    public float countTimer = 5;
    void Start()
    {
        gameOverCountdownText.gameObject.Selective(true);
        countTimer.timeScale = 0;     
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead)
        {
            gameOverCountdown.gameObject.Selective(true);
            countTimer -= countTimer.unscalDeltaTime;
        }
        gameOverCountdown.text = "Restarting in " + ((countTimer).ToString("s");
        if(countTimer < 0)
        {
            
        }
        
    }
    public void statGameOver()
    {

    }
}
