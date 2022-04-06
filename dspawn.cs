using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dspawn : MonoBehaviour
{
    public GameObject spawnObject;
    public Vector3 spawnPoint;
    public int timeToSpawn = 5;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }
    void Spawn()
    {
        if (timer >= timeToSpawn)
        {
            Instantiate(spawnObject, spawnPoint, Quaternion.identity);
            timer = 0;
        }

    }
}
