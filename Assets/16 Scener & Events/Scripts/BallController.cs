using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private EventsHandling eventHandling;

    [SerializeField]
    private string Id;

    private void Start()
    {
        // Här binder vi till att lyssna på händelser
        eventHandling.OnTriggerEnter += ToggleHide;

        eventHandling.OnTriggerEnterWithId += ToggleHideWithId;
    }

    private void OnDestroy()
    {
        // Här slutar vi ta emot att lyssna på händelsen och delegera vidare
        // till toggleHide
        eventHandling.OnTriggerEnter -= ToggleHide;

        eventHandling.OnTriggerEnterWithId -= ToggleHideWithId;
    }

    public void ToggleHide()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void ToggleHideWithId(string targetId)
    {
        if (targetId == Id)
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
