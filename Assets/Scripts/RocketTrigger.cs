using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Rocket"))
        {
         Score._goal++;
        }
    }
    
}
