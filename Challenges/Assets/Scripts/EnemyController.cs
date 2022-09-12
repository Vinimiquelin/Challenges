using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        enemy.transform.position = new Vector3(9, 6 + y, 0);
    }

}
