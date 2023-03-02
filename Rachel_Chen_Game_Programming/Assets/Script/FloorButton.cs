using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButton : MonoBehaviour
{
    int objectsInTrigger = 0;
    SpriteRenderer renderer;
    public Sprite buttonUp;
    public Sprite buttonDown;
    public bool duo = false;
    public FloorButton other;

    public GameObject gate;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (duo)
        {
            if(objectsInTrigger > 0)
            {
                renderer.sprite = buttonDown;
            }
            if (objectsInTrigger == 0)
            {
                gate.SetActive(true);
                renderer.sprite = buttonUp;
            }
            if (other.objectsInTrigger > 0 && objectsInTrigger > 0)
            {
                gate.SetActive(false);
            }
            else
            {
                gate.SetActive(true);
            }
        }
        else
        {
            if (objectsInTrigger > 0)
            {
                renderer.sprite = buttonDown;
                gate.SetActive(false);
            }
            else
            {
                gate.SetActive(true);
                renderer.sprite = buttonUp;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("object entered the trigger " + collision.gameObject.name);
        objectsInTrigger += 1;
        //Debug.Log("objectsInTrigger: " + objectsInTrigger);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("object exited the trigger " + collision.gameObject.name);
        objectsInTrigger -= 1;
        //Debug.Log("objectsInTrigger: " + objectsInTrigger);
    }
}
