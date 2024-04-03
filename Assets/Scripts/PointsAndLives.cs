using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsAndLives : MonoBehaviour
{
    public TMPro.TMP_Text points;
    public TMPro.TMP_Text lives;
    public MyPlayerController4 player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Current Score: " + player.score.ToString();
        lives.text = "Lives: " + player.currentLives.ToString();
    }
}
