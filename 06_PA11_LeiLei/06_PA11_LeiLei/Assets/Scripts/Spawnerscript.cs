﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    private int randomInt;
    
    float PositionY;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
     
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void SpawnObjects()
    {
        randomInt = Random.Range(0, SpawnObject.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[randomInt], transform.position, transform.rotation);
   
    }


  
}
