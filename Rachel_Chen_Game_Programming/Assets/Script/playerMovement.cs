using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector2 playerInput;
    public float speed = 3f;
    public Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerInput.y = Input.GetAxis("Vertical");
        playerInput.x = Input.GetAxis("Horizontal");

        //Debug.Log(playerInput);
    }

    private void FixedUpdate()
    {
        Vector2 velocity = playerInput * speed * Time.deltaTime;

        Vector2 newPosition = (Vector2) transform.position + velocity;

        rbody.MovePosition(newPosition);
    }
}
