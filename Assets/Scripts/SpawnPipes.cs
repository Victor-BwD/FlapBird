using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject[] pipes; // Create a array to get prefabs
    public float height;
    public float maxTime;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject pipeClones = Instantiate(pipes[Random.Range(0, pipes.Length)], transform.position, transform.rotation) as GameObject; // Create a object to instantiate a array of pipes
            pipeClones.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); // Pipes position 
            Destroy(pipeClones, 10f); // Destroy after 10 sec
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}
