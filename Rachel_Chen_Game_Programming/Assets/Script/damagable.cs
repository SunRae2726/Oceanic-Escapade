using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class damagable : MonoBehaviour
{
    public int hitPoints = 3;
    public bool isPlayer = false;
    public SpriteRenderer sprite;
    float timer;


    public void takeDamage(int amount)
    {
        timer = 0.5f;
        hitPoints -= amount;
        if (gameObject.tag == "enemy")
        {
            sprite.color = Color.blue;
        }
        else
        {
            sprite.color = Color.red;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            sprite.color = Color.white;
        }
        if (hitPoints <= 0)
        {
            if (isPlayer)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                Destroy(gameObject);
            }
        }

        
    }
}