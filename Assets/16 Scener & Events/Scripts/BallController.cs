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
        // H�r binder vi till att lyssna p� h�ndelser
        eventHandling.OnTriggerEnter += ToggleHide;

        eventHandling.OnTriggerEnterWithId += ToggleHideWithId;
    }

    private void OnDestroy()
    {
        // H�r slutar vi ta emot att lyssna p� h�ndelsen och delegera vidare
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
