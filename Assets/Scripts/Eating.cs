using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            other.GetComponent<SnakeMovment>().AddTail();
            Destroy(gameObject);
        }
    }
    
}