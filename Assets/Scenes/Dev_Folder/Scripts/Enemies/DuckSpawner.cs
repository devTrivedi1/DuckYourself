using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
	[SerializeField] GameObject spawnDuck;
	[SerializeField] Transform piranha;
    [SerializeField] float minSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float minAngle;
    [SerializeField] float maxAngle;


	public void Spawn()
	{
        float angle = Random.Range(minAngle, maxAngle);
		GameObject duckyDuck = Instantiate(spawnDuck, piranha.position, Quaternion.AngleAxis(angle, Vector3.forward));
        duckyDuck.GetComponent<DuckSpeed>().ChangeMaxSpeed(minSpeed, maxSpeed);
	}
}
