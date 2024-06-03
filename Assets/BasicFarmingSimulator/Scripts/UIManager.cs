using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // textmeshpro
    public TextMeshProUGUI scoreText;
    public int score;

    public TextMeshProUGUI timeText;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore( int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "SCORE:" + score;
    }

}
