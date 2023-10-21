using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject zombie;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn_enemy());
    }
    IEnumerator spawn_enemy()
    {
        GameObject enemy_clone = Instantiate(zombie);
        enemy_clone.transform.position = new Vector3(Random.Range(-26, 27), Random.Range(25,45), 0);
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(spawn_enemy());
    }
    
}
