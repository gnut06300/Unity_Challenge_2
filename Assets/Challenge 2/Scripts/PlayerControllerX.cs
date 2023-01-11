using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float waitTime = 1.0f;
    private float timer = 0.0f;
    //  private float visualTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer > waitTime)
            {
                // Remove the recorded 1 seconds.
                timer = timer - waitTime;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
