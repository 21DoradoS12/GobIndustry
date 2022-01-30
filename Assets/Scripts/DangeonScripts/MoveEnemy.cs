using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float EnemySpeed;
    void Start()
    {
        EnemySpeed = Random.Range(-0.02f, -0.01f);
    }
    void Update()
    {
        transform.position = transform.position + new Vector3(EnemySpeed, 0, 0);
    }
}
