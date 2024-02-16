using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smell : MonoBehaviour
{
    public ThingBrain thing;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Pheromone"))
        {
            Debug.Log("pheromone");
            thing.Smell();
        }
    }
}
