using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
	public GameObject spawnEnemy;
	public float spawnTime;
	public float spawnDelay;
	bool stopSpawning = false;

	void Start()
	{
		Invoke(nameof(Enemy), 1f);
		Invoke(nameof(StopSpawning), 3f);
	}
	void Update()
	{
		/* 	Destroy(this, 1f); */
	}
	void Enemy()
	{
		Instantiate(spawnEnemy, transform.position, transform.rotation);

		if (stopSpawning)
		{
			CancelInvoke("Enemy");
			Debug.Log("Stopped Spawning");
		}

	}

	void StopSpawning()
	{
		stopSpawning = true;
		spawnEnemy.SetActive(false);
	}

	void EnableObject()
	{
		spawnEnemy.SetActive(true);
	}

	void OnDisable()
	{
		if (spawnEnemy.activeInHierarchy)
		{
			Invoke(nameof(EnableObject), 1f);
		}
	}



}
