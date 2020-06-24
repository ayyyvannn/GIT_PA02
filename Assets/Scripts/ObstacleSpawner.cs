using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject tire;
    public GameObject ice;
    public GameObject barrel;
    public GameObject walrus;

    public int spawnNumber;

    public float positionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        spawnNumber = Random.Range(1, 5);

        positionX = Random.Range(-3, 3);

        if (spawnNumber == 1)
        {
            Instantiate(tire, new Vector3(positionX, transform.position.y, transform.position.z), Quaternion.identity);
        }

        else if (spawnNumber == 2)
        {
            Instantiate(ice, new Vector3(positionX, transform.position.y, transform.position.z), Quaternion.identity);
        }

        else if (spawnNumber == 3)
        {
            Instantiate(barrel, new Vector3(positionX, transform.position.y, transform.position.z), Quaternion.identity);
        }

        else if (spawnNumber == 4)
        {
            Instantiate(walrus, new Vector3(positionX, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
