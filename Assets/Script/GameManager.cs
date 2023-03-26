using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public List<GameObject> obstaclePrefab;
    public float obstacleInterval = 3f; 
    public float obstacleSpeed = 10;
    public float obstacleOffSetX = 0;
    public Vector2 obstacleOffSetY;

    [HideInInspector]
    public int score;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

}


