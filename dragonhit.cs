using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonhit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        Destroy(gameObject, 2);
        
        
    }
}
