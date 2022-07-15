using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag("Spike"))
        {
            Debug.Log("Something should've happened here...");
        }
    }
}
