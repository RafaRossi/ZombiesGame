using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject template;
    Terrain terrain;
	// Use this for initialization
	void Start () {
        terrain = this.GetComponent<Terrain>();
        InvokeRepeating("SpawnEnemy", 0, 5);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SpawnEnemy()
    {
        GameObject obj = Instantiate(template);
        Vector3 terrainSize = terrain.terrainData.size;
        Vector3 pos = new Vector3(Random.Range(1, terrainSize.x - 1), 1, Random.Range(1, terrainSize.z - 1));
        obj.transform.position = pos;
    }
}
