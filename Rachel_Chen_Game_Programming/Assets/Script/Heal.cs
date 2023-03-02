using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            damagable player = collision.gameObject.GetComponent<damagable>();
            if (player != null)
            {
                player.hitPoints += 1;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
            }
        }
    }
}
