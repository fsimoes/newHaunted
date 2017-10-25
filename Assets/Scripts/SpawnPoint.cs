﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject spawnGO;

    public int spawnTotal;
    private int spawnCount;
    public float interval;
    float nextSpawn = 0;
    // Use this for initialization
    void Start () {
        //Instantiate(spawnGO, this.transform.position, new Quaternion(-90, 0, 0, 0), this.transform);

    }

    // Update is called once per frame
    void Update () {
        if (nextSpawn < Time.time && spawnCount < spawnTotal)
        {
            nextSpawn = Time.time + interval;
            Instantiate(spawnGO, this.transform.position, new Quaternion(-90, 0, 0, 0), this.transform);
            spawnCount++;
        }
    }

   
}
