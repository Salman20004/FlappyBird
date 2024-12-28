using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject Clouds;
    public float timer = 0;
    public float spawnRate = 2;
    public float hightoffset = 10;
    void Start()
    {
        spawnCloud();
    }

    void Update()
    {
        if (timer < spawnRate) timer += Time.deltaTime; 
        else { spawnCloud();
            timer = 0;
        }
    }
    void spawnCloud()
    {

        float lowest = transform.position.y - hightoffset;
        float hightest = transform.position.y + hightoffset;

        Instantiate(Clouds, new Vector3(transform.position.x, Random.Range(lowest, hightest), 0), transform.rotation);
    }
}
