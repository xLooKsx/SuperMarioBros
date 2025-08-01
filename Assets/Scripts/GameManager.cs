using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Points = 0;

    public Text GameOverText;
    public Text Score;

    void Start()
    {
        // GameOverText.enabled = false;
    }

    public void GameOver()
    {
        GameOverText.GameObject().SetActive(true);
    }

    public void AddPoints(int pointsToAdd)
    {
        this.Points += pointsToAdd;
        this.Score.text = this.Points.ToString();
    }
}
