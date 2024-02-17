using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingBrain : MonoBehaviour
{

    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float health = 100f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float hunger = 40f;

    private Rigidbody2D rb;
    private Vector3 direction;
    public Vector3 target;
    private bool detectFood = false;
    private bool detectThing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("ChangeDirection", 0.1f, 10f);
        InvokeRepeating("Hunger", 0.1f, 3f);
        
    }

    void Update()
    {
        if (health <= 0)
        {
            Death();
        }

        if(transform.position == target)
        {
            ChangeDirection();
        }
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

    // Health

    private void Hunger()
    {
        hunger = hunger - 1;

        if(hunger <= 0)
        {
            Debug.Log("I'm starving!");
            Hurt(2);
        }
        if(hunger >= 10 && health < maxHealth)
        {
            Heal(5);
        }
    }

    public void Hurt(int damage)
    {
        health = health - damage;
    }

    public void Heal(int heal)
    {
        health = health + heal;
    }

    private void Death()
    {
        Debug.Log("I died!");
        Destroy(gameObject);
    }

    // Line of Sight detections:

    public void SawFood(Vector3 foodLocation)
    {
        Debug.Log("saw food");
        detectFood = true;
        target = foodLocation;
        Debug.Log("Going towards food!");
        
    }

    public void SawThing()
    {
        Debug.Log("saw thing");
        detectThing = true;
        // go away from thing
    }

    // Touch detection

    public void TouchFood(int calories)
    {
        Debug.Log("Food!");
        hunger = hunger + calories;
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
