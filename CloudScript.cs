using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour { 
    const float cloudspeed = 10;
    public float deadzoneDespawn = -35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  (Vector3.left * cloudspeed) * Time.deltaTime;
        if (transform.position.x < deadzoneDespawn)
        {
            Debug.Log("Cloud deleted ");
            Destroy(gameObject);
        }
    }
}
