using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovment : MonoBehaviour
{
    public string enemyTag = "Enemy";
    public float speed = 5f;
    private Transform target;
    void Start()
    {
        FindTarget();
    }
    void Update()
    {
        if (target != null)
        {
            MoveTowardsTarget();
        }
        else
        {
            // Если цель не найдена, уничтожаем объект
            Destroy(gameObject);
        }
    }
    void FindTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if (enemies.Length > 0)
        {
            // Находим ближайшего врага по тэгу
            float shortestDistance = Mathf.Infinity;
            foreach (GameObject enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                if (distanceToEnemy < shortestDistance)
                {
                    shortestDistance = distanceToEnemy;
                    target = enemy.transform;
                }
            }
        }
    }
    void MoveTowardsTarget()
    {
        // Двигаемся в сторону цели
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction * speed * Time.deltaTime);

        // Проверяем столкновение с целью
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget < 0.5f)
        {
            // Если достигли цели, уничтожаем объект и цель
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
    }
}
