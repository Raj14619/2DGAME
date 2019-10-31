using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketHit : MonoBehaviour {

    public float WeaponDamage;

    projectileController myPC;

    public GameObject explosionEffect;

    // Use this for initialization
    void Awake()
    {
        myPC = GetComponentInParent<projectileController>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Shootable"))
        {
            myPC.removeForce();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);

            if(collision.tag == "Enemy")
            {
                enemyHealth hurtEnemy = collision.GetComponent<enemyHealth>();
                hurtEnemy.addDamage(WeaponDamage);

            }

        }

       

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Shootable"))
        {
            myPC.removeForce();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);

            if (collision.tag == "Enemy")
            {
                enemyHealth hurtEnemy = collision.GetComponent<enemyHealth>();
                hurtEnemy.addDamage(WeaponDamage);

            }
        }





    }


}
