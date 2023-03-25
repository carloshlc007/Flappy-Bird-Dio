using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    void Update()
    {
        float x = GameManager.Instance.obstacleSpeed * Time.deltaTime;
        transform.position -= new Vector3(x, 0, 0);

        if (transform.position.x <= -GameManager.Instance.obstacleOffSetX)
        {
            Destroy(gameObject);
        }
    }
}
