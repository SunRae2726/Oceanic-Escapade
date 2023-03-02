using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamager : MonoBehaviour
{
    public int power = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject otherGameObject = collision.gameObject;
        damagable playerDamageable = collision.gameObject.GetComponent<damagable>();

        if (playerDamageable != null && collision.gameObject.tag != gameObject.tag)
        {
            if(collision.gameObject.tag == "seeweed" && gameObject.tag == "enemy")
            {

            }
            else
            {
                playerDamageable.takeDamage(power);
            }
            
        }

    }

}
