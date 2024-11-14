using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerScript : MonoBehaviour
{
    // Ex 1
    /*
    [SerializeField]
    private GameObject ballReference;
    */

    /*
    [SerializeField]
    private TMP_Text scoreValue;
    */

    //private int score = 0;

    // Ex2
    [SerializeField]
    private EventsHandling eventHandling;

    [SerializeField]
    private string targetId;

    private void OnTriggerEnter(Collider other)
    {
        // Ex 1
        // score++;
        // scoreValue.text = score.ToString();

        // ballReference.SetActive(!ballReference.activeSelf);

        // Ex2
        // eventHandling.TriggerEnter();

        // Ex3
        eventHandling.TriggerEnterWithId(targetId);
    }
}
