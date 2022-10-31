using System.Collections;
using UnityEngine;

public class TailMovment : MonoBehaviour
{
    public float Speed;
    
    public Vector3 tailTarget;

    public int Index;

    public GameObject tailTargetObj;

    public SnakeMovment Snake; 

    void Start()
    {
        Snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<SnakeMovment>();
        Speed = Snake.Speed;
        tailTargetObj = Snake.tailObjects[Snake.tailObjects.Count - 2];
        Index = Snake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            if(Index > 2)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
