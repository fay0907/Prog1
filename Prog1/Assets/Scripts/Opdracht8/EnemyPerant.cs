using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPerant : MonoBehaviour, IMovable, IDamagable
{
    public int health;
    public int Health
    {
        get { return health; }
    }
    public int speed;
    [SerializeField] GameObject PointB;

    void Update()
    {
       Move();
    }

    public virtual void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, PointB.transform.position, speed * Time.deltaTime);
    }
    

    public void TakeDamage()
    {
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
