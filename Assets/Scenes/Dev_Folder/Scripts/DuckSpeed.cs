using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpeed : MonoBehaviour
{
	Rigidbody2D rb;
	float duckSpeed;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		DuckMovement();
	}



	void DuckMovement()
	{
		rb.AddForce(transform.up * duckSpeed);
	}

	public void ChangeMaxSpeed(float minSpeed, float maxSpeed)
	{
		duckSpeed = Random.Range(minSpeed, maxSpeed);
	}
}
