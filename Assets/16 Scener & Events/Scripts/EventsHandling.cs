using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsHandling : MonoBehaviour
{
    public event Action OnTriggerEnter;
    public event Action<string> OnTriggerEnterWithId;

    [Serializable]
    public class OnTriggerEvent : UnityEvent { };
    public OnTriggerEvent onTriggerEnter;

    private void Start()
    {
        onTriggerEnter.AddListener(TriggerEnterHandling);
    }

    private void TriggerEnterHandling() {
        Debug.Log("You have trigger the enter");
    }

    public void TriggerEnter()
    {
        OnTriggerEnter.Invoke();
    }

    public void TriggerEnterWithId(string id) {
        OnTriggerEnterWithId.Invoke(id);

    }
}
