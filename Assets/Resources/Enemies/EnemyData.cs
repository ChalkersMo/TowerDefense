using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Stats")]
    [SerializeField] private float _damage, _health, _speed, _worth, _deathPrice;

    [Header("Visuals")]
    [SerializeField] private GameObject _model;

    public float Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public float Worth
    {
        get { return _worth; }
        set { _worth = value; }
    }

    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    public float DeathPrice
    {
        get { return _deathPrice; }
        set { _deathPrice = value; }
    }

    public GameObject Model
    {
        get { return _model; }
        set { _model = value; }
    }
}