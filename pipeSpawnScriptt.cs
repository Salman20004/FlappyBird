using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnScriptt : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2;
    private float timer = -2;
    public float hightoffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate) {
        
            timer += Time.deltaTime;
        }
        else { 
        
            SpawnPipe();
            timer =-2;
        }

    }
    void SpawnPipe()
    {
        float lowest = transform.position.y - hightoffset;
        float hightest = transform.position.y + hightoffset;

        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowest,hightest),0), transform.rotation);

    }
}
