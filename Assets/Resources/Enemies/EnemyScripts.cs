using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [Header("Key Values")]
    public EnemyData stats;
    //public Transform paths;

    [Header("Stats")]
    [SerializeField] private float damage;
    [SerializeField] private float health;  
    [SerializeField] private float speed;
    [SerializeField] private float worth;


    void Start()
    {
        health = stats.Health;
        speed = stats.Speed;
        damage = stats.Damage;
        worth = stats.Worth;
    }

    
    void Update()
    {
        if(health <= 0) { Die(); }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            //TakeDamage();
            health -= collision.gameObject.GetComponent<bullet>().damage;
            Debug.Log("collide bullet");
        }
    }

    private void TakeDamage()
    {
        
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
