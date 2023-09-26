using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text highScore;
    public int scoreIndex;

    public GameObject ballPrefab;
    public Vector3 spawnPos;

    private bool isInstantiated;


    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();

        isInstantiated = false;

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            scoreIndex++; 
            UpdateScore();
        }
    }

    private void Update()
    {
        SpawnBall();
    }

    void UpdateScore()
    {
        score.text = scoreIndex.ToString();

        if (scoreIndex > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", scoreIndex);
            highScore.text = scoreIndex.ToString();
        }

    }

    void SpawnBall()
    {
        if (scoreIndex > 5 && !isInstantiated)
        {
            Instantiate(ballPrefab, spawnPos, Quaternion.identity);
            isInstantiated = true;

        }
    }

}
