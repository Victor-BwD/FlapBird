using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    
    public float speed = 1f;
    private Rigidbody2D rig;

    public GameObject gameOver;

    void Start()
    {
        
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = Vector2.up * speed;
        }

        transform.eulerAngles = new Vector3(0, 0, rig.velocity.y * 6f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}