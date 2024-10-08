using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKeyDown(KeyCode.A);
            {
            ; //Move the player left
            }
        Input.GetKeyDown(KeyCode.D);
        {
            ; //Move the player right
        }
    }
}