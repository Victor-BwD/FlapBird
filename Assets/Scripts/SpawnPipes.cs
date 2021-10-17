using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject[] pipes;
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
            GameObject pipeClones = Instantiate(pipes[Random.Range(0, pipes.Length)], transform.position, transform.rotation) as GameObject;
            pipeClones.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(pipeClones, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}
