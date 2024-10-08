using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverPattern : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This is my observer
        //The observer will look at the players state like a state machine
        //The observer will help me with the players state and what should be done when certain conditions are happening
    }

    // Update is called once per frame
    void Update()
    {

        //If the player is doing nothing it will sit there idle
        //If the player is pressing space it will shoot out bullets
        //If the player comes in contact with a bullet then it will be destroyed

        //The same goes with the enemies

    }
}
