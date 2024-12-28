using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddleobject : MonoBehaviour
{ private BirdScript Bird;
    public LogicScript logic;
  

    void Start()
    {
        Bird = GameObject.FindGameObjectWithTag("Bird1").GetComponent<BirdScript>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>(); 
    }

    // Update is called once per frame
   private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3&& Bird.BirdIsAlive)
        {
            logic.addscore(1);
        }
    }


}
