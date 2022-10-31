using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovment : MonoBehaviour
{
    public float Speed;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float zOffset = 0.5f;
    public GameObject TailPrefab;
    public float Sensitivity;
    public Transform SnakeTransform;
 

    void Start()
    {
        tailObjects[0] = gameObject;
    }
 
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.position += new Vector3(Sensitivity, 0, 0) * Input.GetAxis("Horizontal");
    }

    public void AddTail()
    { 
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= zOffset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
        EatSound();
    }

    public void EatSound()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
