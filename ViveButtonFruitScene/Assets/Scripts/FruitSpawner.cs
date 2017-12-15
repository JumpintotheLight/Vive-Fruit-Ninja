﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

    public GameObject[] fruitPrefab;
    public float spawn_range = 1f;
    private bool doubleFruit = false;
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnFruit());
	}
	

    IEnumerator SpawnFruit()
    {
        while (true)
        {
            if (doubleFruit)
            {
                Debug.Log("Double Fruit Started");
                GameObject go1 = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)]);
                Rigidbody temp1 = go1.GetComponent<Rigidbody>();

                temp1.velocity = new Vector3(0f, 5f, .5f);
                temp1.angularVelocity = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
                temp1.useGravity = true;

                Vector3 pos1 = transform.position;
                pos1.x += Random.Range(-spawn_range, spawn_range);
                go1.transform.position = pos1;

                GameObject go2 = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)]);
                Rigidbody temp2 = go2.GetComponent<Rigidbody>();

                temp2.velocity = new Vector3(0f, 5f, .5f);
                temp2.angularVelocity = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
                temp2.useGravity = true;

                Vector3 pos2 = transform.position;
                pos2.x += Random.Range(-spawn_range, spawn_range);
                go2.transform.position = pos2;
            }
            else
            {
                GameObject go = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)]);
                Rigidbody temp = go.GetComponent<Rigidbody>();

                temp.velocity = new Vector3(0f, 5f, .5f);
                temp.angularVelocity = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
                temp.useGravity = true;

                Vector3 pos = transform.position;
                pos.x += Random.Range(-spawn_range, spawn_range);
                go.transform.position = pos;
            }
            yield return new WaitForSeconds(1f);
        }

    }
    public void setDoubleFruit(bool newFruit)
    {
        Debug.Log("Called doublefruit set");
        Debug.Log(newFruit);
        doubleFruit = newFruit;
    }
    public bool getDoubelFruit()
    {
        return doubleFruit;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
