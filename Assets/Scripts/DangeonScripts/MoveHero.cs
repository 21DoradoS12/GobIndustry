using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;
    public float HeroSpeed = 0.01f;
    public float Num_Enemy;
    private DangeonTime dungeon;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
        dungeon = GameObject.FindObjectOfType<DangeonTime>();
        if (bank.DungeonOn1 == true)
            Num_Enemy = Random.Range(1, 6);
        if (bank.DungeonOn2 == true)
            Num_Enemy = Random.Range(6, 11);
        if (dungeon.DungeonTime > 0)
            Spawn_Enemy();
    }
    void Update()
    {
        transform.position = transform.position + new Vector3(HeroSpeed, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        if (collision.tag == "Teleport")
        {
            if (bank.DungeonOn1 == true)
            {
                Num_Enemy = Random.Range(1, 6);
                transform.position = new Vector3(-4, 0, 0);
                if (dungeon.DungeonTime > 0)
                    Spawn_Enemy();
            }
            if (bank.DungeonOn2 == true)
            {
                Num_Enemy = Random.Range(6, 11);
                transform.position = new Vector3(-4, 0, 0);
                if (dungeon.DungeonTime > 0)
                    Spawn_Enemy();
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
    public void Spawn_Enemy()
    {
        if (Num_Enemy == 1)
            Instantiate(Enemy1, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 2)
            Instantiate(Enemy2, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 3)
            Instantiate(Enemy3, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 4)
            Instantiate(Enemy4, new Vector3(4, 0, 0), Quaternion.identity);
        if (Num_Enemy == 5)
            Instantiate(Enemy5, new Vector3(4, 0, 0), Quaternion.identity);
        if (Num_Enemy == 6)
            Instantiate(Enemy6, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 7)
            Instantiate(Enemy7, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 8)
            Instantiate(Enemy8, new Vector3(4, 0.5f, 0), Quaternion.identity);
        if (Num_Enemy == 9)
            Instantiate(Enemy9, new Vector3(4, 0, 0), Quaternion.identity);
        if (Num_Enemy == 10)
            Instantiate(Enemy10, new Vector3(4, 0, 0), Quaternion.identity);
    }
}
