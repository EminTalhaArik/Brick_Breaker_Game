using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBrickManager : BrickObject
{
    [Header("Spawner Brick Manager")]
    [SerializeField] private GameObject MinimalBallPrefab;
    [SerializeField] private GameObject DamageEffectPrefab;
    [SerializeField] private int SpawnableObjectCount = 2;

    public override void HealthControl()
    {
        SpawnDamageEffect();
        if (ObjectHealth <= 0)
        {
            Debug.Log(ObjectName + " is destroyed");
            SpawnMinimalBalls();
            Destroy(this.gameObject);
        }
    }

    public void SpawnDamageEffect()
    {
        Instantiate(DamageEffectPrefab, transform.position, Quaternion.identity);
    }

    public void SpawnMinimalBalls()
    {
        for (int i = 0; i < SpawnableObjectCount; i++)
        {
            GameObject spawnObject = Instantiate(MinimalBallPrefab, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            spawnObject.GetComponent<MinimalBallManager>().ForceToBall(Mathf.Round(Random.Range(100, 250)));
        }
    }
}
