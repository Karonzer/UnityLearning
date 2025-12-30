using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Coroutine spawn;
    [SerializeField] private float spawnTime;
    [SerializeField] private Vector3 spawnPos;

    private void Start()
    {
        //spawn = StartCoroutine(SpawnCoroutine());
    }

    private void OnEnable()
    {
        spawnTime = 5;
    }

    private void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            spawnTime = 5;
            SpwanCreate();
        }
    }

    private IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            SpwanCreate();
            yield return new WaitForSeconds(spawnTime);
        }
    }


    private void SpwanCreate()
    {
        GameObject objClone = Instantiate(prefab);
        objClone.transform.position = spawnPos;
        spawnPos += Vector3.left;
        objClone.transform.Rotate(0, 180f, 0);
    }

}
