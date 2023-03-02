using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float timer;
    public int power = 1;

    // Start is called before the first frame update
    void Start()
    {
        timer = 9f / 18f - 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        damagable playerDamageable = collision.gameObject.GetComponent<damagable>();
        if (playerDamageable != null)
        {
            playerDamageable.takeDamage(power);
        }
    }
}
