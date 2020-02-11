using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Add OnTriggerEnter function using autocomplete
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // when the animal collides with food, food is destroyed
        Destroy(other.gameObject); // animal is destroyed during collision 
    }
}
