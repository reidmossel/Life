using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingBrain : MonoBehaviour
{

    [SerializeField] private float maxSpeed = 10f;

    // [SerializeField] private float hunger = 40f;

    private Rigidbody2D rb;
    private Vector3 direction;
    public Vector3 target;
    private bool detectFood = false;
    private bool detectThing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("ChangeDirection", 0.1f, 10f);
        
    }

    void Update()
    {

    }

    void FixedUpdate() 
    {

        transform.up = target - transform.position;
        rb.velocity = (transform.up * Time.deltaTime * maxSpeed);

    }

    private void ChangeDirection()
    {
        if (!detectFood && !detectThing)
        {
            target = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        }
    }


    // Line of Sight detections:

    public void SawFood(Vector3 foodLocation)
    {
        Debug.Log("saw food");
        detectFood = true;
        // Go towards food
        // Need to make it so they turn towards the food
        target = foodLocation;
        Debug.Log("Going towards food!");
        
    }

    public void SawThing()
    {
        Debug.Log("saw thing");
        detectThing = true;
        // go away from food
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
