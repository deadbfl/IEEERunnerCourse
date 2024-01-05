using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] private float increaseAmount;

    [SerializeField] private TMP_Text scoreText;

    private float score;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * increaseAmount;
        UpdateScoreText();
    }

    public void ChangeScore(float value)
    {
        score += value;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Score degistigi her yerde cagrilmalidir
    {
        scoreText.SetText("Score : " + (int)score);
    }

    public float GetScore()
    {
        return score;
    }
}
