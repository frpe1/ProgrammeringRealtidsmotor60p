using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandling : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreValue;

    private int score = 0;

    [SerializeField]
    private EventsHandling eventHandling;

    private void Start()
    {
        eventHandling.OnTriggerEnter += IncreaseScore;
    }

    private void OnDestroy()
    {
        // H�r slutar vi ta emot att lyssna p� h�ndelsen och delegera vidare
        // till IncreaseScore
        eventHandling.OnTriggerEnter -= IncreaseScore;
    }

    public void IncreaseScore() {
        score++;
        scoreValue.text = score.ToString();
    }
}
