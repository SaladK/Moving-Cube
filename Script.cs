using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Health NPC
    int Health = 5;
    // Level NPC
    int Level = 1;
    // Speed NPC
    float Speed = 1.2f;
    int debounce = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        //print(Speed, Health, Level);
        Health += Level;
        print(Health);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (debounce <= 800 )
        {
            Speed = 9.5f;
            debounce += 1;
            Vector3 newPosition;
            // Transform position;
            newPosition = transform.position;
            newPosition.z += Speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (debounce >= 800)
        {
            Speed = -11.0f;
            debounce += 1;
            Vector3 newPosition;
            // Transform position;
            newPosition = transform.position;
            newPosition.z += Speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (debounce >= 1600)
        {
            Speed = 13.0f;
            debounce = 0;
            Vector3 newPosition;
            // Transform position;
            newPosition = transform.position;
            newPosition.z += Speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
