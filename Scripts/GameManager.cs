using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private float radius = 10f;
    [SerializeField] private int spawnAmount = 10;
    // Get references to prefabs
    // public GameObject thingPrefab;
    // public GameObject pelletPrefab;

    public GameObject[] prefabs;

    void Update()
    {
        

        // if(press button) { Randomly pawn a bunch of things and pellets in a certain area }
        // Will add a way to check if there's already a thing there so they don't spawn on top of each other
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate(thingPrefab, spawnArea, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            // Instantiate(pelletPrefab, spawnArea, Quaternion.Euler(0, 0, Random.Range(0, 360)));

            for(int i = 0; i < spawnAmount; i++)
            {
                var spawnArea = Random.insideUnitCircle * radius;
                Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnArea, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            }
        }
    }
}
