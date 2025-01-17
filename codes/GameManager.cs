using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public player player;
    public ScoreManager scoreManager;
    public AudioSource backgroundSound;
    public AudioSource deathSound;

    private Vector3 playerStartingPoint;
    private Vector3 groundGenerationStartPoint;

    public GroundGenerator groundGenerator;

    public GameObject largeGround;
    public GameObject mediumGround;
    

    public GameObject gameOverScreen;
    // Start is called before the first frame update
    
    public void Start()
    {
        playerStartingPoint = player.transform.position;
        groundGenerationStartPoint = groundGenerator.transform.position;
        gameOverScreen.SetActive(false);
        
    }

    // Update is called once per frame
    public void GameOver(){
        player.gameObject.SetActive(false);
        gameOverScreen.SetActive(true);
        scoreManager.isScoreIncreasing = false;
        backgroundSound.Stop();
        deathSound.Play();
        
    }
    public void Quit(){
        Application.Quit();
    }

    public void Restart(){
        GroundDestroyer[] destroyer = FindObjectsOfType<GroundDestroyer>();
        for(int i=0;i<destroyer.Length;i++){
            destroyer[i].gameObject.SetActive(false);
        }
        largeGround.SetActive(true);
        mediumGround.SetActive(true);
        player.transform.position =playerStartingPoint;
        groundGenerator.transform.position = groundGenerationStartPoint;
        gameOverScreen.SetActive(false);
        player.gameObject.SetActive(true);
        backgroundSound.Play();
        scoreManager.Score = 0;
        scoreManager.isScoreIncreasing = true;
    }
}
