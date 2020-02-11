using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// If any objects move out of bounds, destroy them
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy projectiles offscreen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // Destroy animals offscreen
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
