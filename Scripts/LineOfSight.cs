using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{

    public ThingBrain thing;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Pellet"))
        {
            thing.SawFood();
        }

        if(collider.CompareTag("Thing"))
        {
            thing.SawThing();
        }
    }
}
