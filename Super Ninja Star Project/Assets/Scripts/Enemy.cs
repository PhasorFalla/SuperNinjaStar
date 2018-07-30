using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject deathVFX;

    private void OnCollisionEnter2D(Collision2D other)
    {
        print("hit something");

        if (other.gameObject.CompareTag("Player"))
        {

            print("hit player");
            if (other.gameObject.GetComponent<Grapple>().tethered)
            {
                other.gameObject.GetComponent<Grapple>().Detatch();
                FanReset.deathzone.ResetEntity(other.gameObject);

            }
            else
            {
                EnemyDeath();
            }




        }
    }

    public void EnemyDeath()
    {
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void HurtPlayer()
    {

    }
}
