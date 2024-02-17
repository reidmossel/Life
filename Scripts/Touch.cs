using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public ThingBrain thing;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.CompareTag("Pellet"))
        {
            thing.TouchFood(10);
            Destroy(collider.gameObject);
        }

        if(collider.CompareTag("Thing"))
        {
            thing.TouchThing();
        }
    }
}
