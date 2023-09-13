using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject MuzzleFlash;
    public AudioSource PistolShot;
    public float TargetDistance;
    public int DamageAmount = 5;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    }

    IEnumerator FireThePistol()
    {
        RaycastHit Shot;
        isFiring = true;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        blackPistol.GetComponent<Animator>().Play("FirePistol");
        PistolShot.Play();
        MuzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        MuzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}