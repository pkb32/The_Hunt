using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;
    
    public float t;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
        TheEnemy.GetComponent<Animation>().Play("Walk");
        TheEnemy.GetComponent<Animation>().Play("Attack");

    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            StatusCheck = 2;
           // TheEnemy.GetComponent<Animation>().Stop("Walk");
            TheEnemy.GetComponent<Animation>().Stop("Attack");
           // TheEnemy.GetComponent<Animation>().Play("FallBack");

            Destroy(TheEnemy, t = 0.0f);
        }
    }
}