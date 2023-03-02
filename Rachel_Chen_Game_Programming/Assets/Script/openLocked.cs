using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLocked : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inventory playerInventory = collision.gameObject.GetComponent<inventory>();
        if (playerInventory.actualKey > 0 && playerInventory != null)
        {
            playerInventory.actualKey -= 1;
            Destroy(gameObject);
        }
    }
}
