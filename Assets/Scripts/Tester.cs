using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.StartListening(Events.testEvent1 , Event1);
        EventManager.StartListening(Events.testEvent2, Event2);
    }

    private void OnDisable()
    {
        EventManager.StopListening(Events.testEvent1, Event1);
        EventManager.StopListening (Events.testEvent2, Event2);
    }

    void Event1(object sender)
    {
        Debug.Log("Called Event1");
    }
    void Event2(object sender)
    {
        int parameter = (int)sender;
        Debug.Log("Called Event2 and the value is " + parameter.ToString());
    }
}
