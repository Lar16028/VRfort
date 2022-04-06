using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public float force;
    Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r =  GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        r.AddForce(transform.right * force);
    }
}
