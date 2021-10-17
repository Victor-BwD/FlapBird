using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    public void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
