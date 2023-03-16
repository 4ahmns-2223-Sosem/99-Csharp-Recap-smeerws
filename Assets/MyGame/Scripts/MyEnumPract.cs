using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WIP,
    Cancel
}

public class MyEnumPract : MonoBehaviour
{
    //Deklaration
    State myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = State.Cancel;
        int i = 0;

        switch (myState)
        {
            case (int)State.Done: 
                Debug.Log(State.Done + " " +(int)State.Done);
                break;
            case State.WIP:
                Debug.Log((int)State.WIP);
                break;
            case State.Cancel:
                Debug.Log((int)State.Cancel);
                break;
        }

        if (myState == State.Done)
        {
            Debug.Log(State.Done + " " + (int)State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.WIP);
        }
        else
        {
            Debug.Log(State.Cancel);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
