using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int hitPoints = 3;
    public float speed = 4.5f;
    public string characterName = "Rachel";
    public bool isWeekend = false;
    public Vector2 position;
    public SpriteRenderer renderer;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("HP: " + hitPoints);
        Debug.Log("I move at " + speed + " Units per second.");
        Debug.Log("My name is " + characterName);

        if(isWeekend == true)
        {
            Debug.Log("Go to the beach!");
        }
        else
        {
            Debug.Log("Stay home and work :( ");
        }

        TakeDamage(2);
        Debug.Log("HP: " + hitPoints);

        Debug.Log("Horizontal Position (x) is: " + position.x);
        Debug.Log("Horizontal Position (y) is: " + position.y);
    }

    public void TakeDamage(int amount)
    {
        hitPoints -= amount;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Updating...");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //set color of renderer to red
            renderer.color = Color.red;
            //renderer.color = new Color(1, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //set color of renderer back to white
            renderer.color = Color.white;
        }

    }

    //version of update for physics.
    private void FixedUpdate()
    {
        
    }
}
