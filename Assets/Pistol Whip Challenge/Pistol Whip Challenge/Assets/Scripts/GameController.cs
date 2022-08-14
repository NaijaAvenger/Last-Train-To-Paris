using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public float lives = 5f;
    public TextMeshProUGUI livesText;

    public float score = 0f;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives <0)
        {
            lives = 0;
        }
        scoreText.text = "Score: " + score.ToString();
    }
}
