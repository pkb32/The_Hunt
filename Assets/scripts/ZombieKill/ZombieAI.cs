using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.05f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource HurtSound01;
    public AudioSource HurtSound02;
    public AudioSource HurtSound03;
    public int HurtGen;

    

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.05f;
           // theEnemy.GetComponent<Animation>().Play("Walk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Attack");
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }


    IEnumerator InflictDamage()
    {
        isAttacking = true;
        HurtGen = Random.Range(1, 4);
        if (HurtGen == 1)
        {
            HurtSound01.Play();
        }
        if (HurtGen == 2)
        {
            HurtSound02.Play();
        }
        if (HurtGen == 3)
        {
            HurtSound03.Play();
        }
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 10;
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;
    }

}