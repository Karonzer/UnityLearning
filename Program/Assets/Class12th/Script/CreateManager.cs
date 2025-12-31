using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Coroutine spawn;
    [SerializeField] private float spawnTime;
    [SerializeField] private Vector3 spawnPos;

    [SerializeField] private List<GameObject> spawnList;

    private WaitForSeconds waitFor;

    private void Start()
    {
        spawn = StartCoroutine(SpawnCoroutine());
        waitFor = new WaitForSeconds(spawnTime);
    }

    private void OnEnable()
    {
        spawnTime = 5;
    }

    private void Update()
    {
        //spawnTime -= Time.deltaTime;
        //if (spawnTime <= 0)
        //{
        //    spawnTime = 5;
        //    SpwanCreate();
        //}
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            SpwanCreate();
            yield return waitFor;
        }
    }


    private void SpwanCreate()
    {
        int randomValue = Random.Range(0, spawnList.Count);
        GameObject objClone = Instantiate(prefab, spawnList[randomValue].transform.position,
            Quaternion.Euler(0,180f,0), gameObject.transform);
    }

}
