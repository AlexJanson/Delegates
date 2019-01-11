﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject prefab;
	public Transform spawnHolder;
    
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1f);
        prefab.transform.position = new Vector3(Random.RandomRange(-2f, 2f), 0, Random.RandomRange(-2f, 2f));
        Instantiate(prefab, spawnHolder);
        yield return StartCoroutine(SpawnEnemy());
    }
}
