using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingBrain : MonoBehaviour
{

    [SerializeField] private float maxSpeed = 3f;
    // [SerializeField] private float hunger = 40f;

    // public GameObject sight;
    // public GameObject smell;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate() 
    {
        // Make this random
        rb.velocity = (Vector2.up * Time.deltaTime * maxSpeed);
    }


    // Line of Sight detections:

    public void SawFood()
    {
        Debug.Log("saw food");
        // Go towards or away from the thing
    }

    public void SawThing()
    {
        Debug.Log("saw thing");
    }


    // Touch detection

    public void TouchFood()
    {
        Debug.Log("Food!");
    }

    public void TouchThing()
    {
        Debug.Log("Cuddles!");
    }


    // Pheremone detctions:

    public void Smell()
    {
        Debug.Log("smell");
        // React to the pheremones
    }
}
