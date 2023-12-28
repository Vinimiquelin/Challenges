using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public float speed;
    public float amplitude;

    private float initialY;

    void Start()
    {
        initialY = enemy.transform.position.y;
    }

    public void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * speed) * amplitude;
        enemy.transform.position = new Vector3(enemy.transform.position.x, initialY + verticalMovement, 0);
    }
}

