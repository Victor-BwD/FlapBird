﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int score;
    public Text scoreText;
    //public Transform birdPrefab;

    void Start()
    {
        //Instantiate(birdPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
