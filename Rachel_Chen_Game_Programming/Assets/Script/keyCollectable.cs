using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyCollectable : MonoBehaviour
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
            inventory playerInventory = collision.gameObject.GetComponent<inventory>();
            if (playerInventory != null)
            {
                playerInventory.keys += 1;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                if (playerInventory.keys == 5)
                {
                    SceneManager.LoadScene("congrats");
                }
            }
        }
    }
}
