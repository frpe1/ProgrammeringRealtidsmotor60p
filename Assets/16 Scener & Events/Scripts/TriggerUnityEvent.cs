using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerUnityEvent : MonoBehaviour
{
    [SerializeField]
    private EventsHandling eventHandling;


    private void OnTriggerEnter(Collider other)
    {
        eventHandling.onTriggerEnter.Invoke();
    }
}
