using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public int timeToSpawn;
    float timer = 0;

    public void shooty(){
        if (timer >= timeToSpawn){
            Instantiate(projectile, GetComponent<Transform>().position, Quaternion.identity);
            timer = 0;
        }
    }

    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        shooty();
    }
}

