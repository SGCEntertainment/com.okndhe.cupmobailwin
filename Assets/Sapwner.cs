using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapwner : MonoBehaviour
{
    public GameObject platformPrefab;

    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;

    void Start()
    {
        StartCoroutine(SpawnObj());
    }

    private IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(2.25f);
        Vector3 SpawnerPosition = new Vector3();

        SpawnerPosition.x = Random.Range(xMin, xMax);
        SpawnerPosition.y += Random.Range(yMin, yMax);

        Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        
        StartCoroutine(SpawnObj());

    }
}
