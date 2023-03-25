using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float countDown = 1;

    private void Start()
    {
        countDown = GameManager.Instance.obstacleInterval;
    }
    void Update()
    {
        var gameManager = GameManager.Instance;

        countDown -= Time.deltaTime;
        
        if (countDown <= 0)
        {
           
            countDown = gameManager.obstacleInterval;

            int prefabIndex = Random.Range(0, gameManager.obstaclePrefab.Count);

            GameObject prefab = gameManager.obstaclePrefab[prefabIndex];
            float x = gameManager.obstacleOffSetX;
            float y = Random.Range(gameManager.obstacleOffSetY.x, gameManager.obstacleOffSetY.y);
            float z = 0;

            Vector3 position = new Vector3(x, y, z);
            Quaternion rotation = prefab.transform.rotation;

            Instantiate(prefab, position, rotation);

        }
    }
}
