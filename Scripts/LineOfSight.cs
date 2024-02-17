using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{

    public Vector2 foodLocation;
    public Vector2 thingLocation;
    public ThingBrain thing;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Pellet"))
        {
            foodLocation = collider.transform.position;
            thing.SawFood(foodLocation);
        }

        if(collider.CompareTag("Thing"))
        {
            thing.SawThing();
        }
    }
}
