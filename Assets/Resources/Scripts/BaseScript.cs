using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseScript : MonoBehaviour
{
    [Header("Base stats")]
    public string enemytag = "Enemy";
    public float HP = 100;
    public EnemyData stats;
    private float damage;
    public TMP_Text healthText;

    [Header("Build stats")]
    public float baseMoney;
    public TMP_Text moneyText;


    [Header("Lose values")]
    public loseScript LoseScript;

    void Start()
    {
        damage = stats.Damage;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == enemytag)
        {
            HP -= damage;
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        ReloadText();
        if(HP <= 0)
        {
            LoseScript.Lose();
        }

        if (baseMoney >= LoseScript.moneyToWin)
        {
            LoseScript.Win();
        }
    }

    public void ReloadText()
    {
        moneyText.text = $"Money: " + baseMoney;
        healthText.text = $"Health: " + HP;
    }
}
