using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeaderUI : MonoBehaviour {
    public TextMeshProUGUI score;
    public TextMeshProUGUI highestScore;
    private static readonly int factor = 10;
    void Start() {
        score.text = scoreToUI();
        highestScore.text = highestScoreToUI();
    }

    void Update() {
        score.text = scoreToUI();
        highestScore.text = highestScoreToUI();
    }

    private string scoreToUI(){
        return (GameManager.Instance.GetScore() * factor).ToString();
    }

    private string highestScoreToUI() {
        return (GameManager.Instance.GetHighestScore() * factor).ToString();
    }
}
