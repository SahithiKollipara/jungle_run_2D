using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float points;

    public TMP_Text scoreText;
    public TMP_Text hiScoreText;

    public float Score;
    private float HiScore;

    public bool isScoreIncreasing;

    void Start()
    {
        isScoreIncreasing = true;

        if(PlayerPrefs.HasKey("HiScore")){
            HiScore = PlayerPrefs.GetFloat("HiScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isScoreIncreasing)
           Score += points * Time.deltaTime;

        if(Score>HiScore){
            HiScore = Score;
            PlayerPrefs.SetFloat("HiScore",HiScore);
        }

        scoreText.text = Mathf.Round(Score).ToString();
        hiScoreText.text = Mathf.Round(HiScore).ToString();
    }
}

