using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBrickManager : BrickObject
{
    [Header("Spawner Brick Manager")]
    [SerializeField] private GameObject MinimalBallPrefab;

    public override void HealthControl()
    {
        if (ObjectHealth <= 0)
        {
            Debug.Log(ObjectName + " is destroyed");
            SpawnMinimalBalls();
            Destroy(this.gameObject);
        }
    }

    public void SpawnMinimalBalls()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject spawnObject = Instantiate(MinimalBallPrefab, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            spawnObject.GetComponent<MinimalBallManager>().ForceToBall(Mathf.Round(Random.Range(100, 250)));
        }
    }
}
