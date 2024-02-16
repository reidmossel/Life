using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public ThingBrain thing;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Pellet"))
        {
            thing.TouchFood();
        }

        if(collider.CompareTag("Thing"))
        {
            thing.TouchThing();
        }
    }
}
