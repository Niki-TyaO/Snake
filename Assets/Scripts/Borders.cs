using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public float Speed;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
