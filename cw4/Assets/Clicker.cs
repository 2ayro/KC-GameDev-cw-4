using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public int Score = 0;
    public int Power =1;
    public TextMeshProUGUI ScoreText;

    public void PressMe () 
    {
        Score = Score + Power;
        ScoreText.text = "Score: "+Score;
        print(Score);
    }

    public void BuyItem ()
    {
        if(Score >= 10)
        {
            Power++;
            Score = Score - 10;
            ScoreText.text = "Score: "+Score;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
