using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishManager : MonoBehaviour
{
    public static FinishManager instance;

    [SerializeField] private GameObject finishPanel;
    [SerializeField] private GameObject closeScoreText;

    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void SetFinishPanel()
    {
        OpenFinishPanel();
        CloseScoreText();
        ChangeScoreText();
    }

    private void OpenFinishPanel()
    {
        finishPanel.SetActive(true);
    }

    private void CloseScoreText()
    {
        closeScoreText.SetActive(false);
    }

    private void ChangeScoreText()
    {
        scoreText.SetText("Skorunuz : " + ScoreManager.instance.GetScore());
    }
}
