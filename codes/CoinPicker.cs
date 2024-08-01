using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource coinPickSound;

    private float coinPoints = 1f;
    private ScoreManager scoreManager;
    void Start()
    {
        coinPickSound = GameObject.Find("CoinPickSound").GetComponent<AudioSource>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            gameObject.SetActive(false);
            if(coinPickSound.isPlaying){
             coinPickSound.Stop();
            }
            coinPickSound.Play();
            scoreManager.Score += coinPoints;
        }
    }
}
