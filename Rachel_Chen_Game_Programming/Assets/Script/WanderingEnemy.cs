using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingEnemy : MonoBehaviour
{
	public float speed = 2f;
	public float walkTime = 1.5f;
	float timer;

	Rigidbody2D rigidbody;
	Vector2 direction;

	// Start is called before the first frame update
	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		PickRandomDirection();
	}

	// Update is called once per frame
	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0)
			PickRandomDirection();
	}

	void PickRandomDirection()
	{
		int selection = Random.Range(0, 4);
		Vector2 lastDirection = direction;

		if (selection == 0)
			direction = Vector2.left;
		if (selection == 1)
			direction = Vector2.right;
		if (selection == 2)
			direction = Vector2.up;
		if (selection == 3)
			direction = Vector2.down;

		if (direction == lastDirection)
			PickRandomDirection();

		timer = walkTime;
	}

	private void FixedUpdate()
	{
		Vector2 newPosition = (Vector2)transform.position + (direction * speed * Time.fixedDeltaTime);
		rigidbody.MovePosition(newPosition);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		direction = direction * -1;
	}
}
