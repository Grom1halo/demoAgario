using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public Food GameObject;
    public float spawnTime;
    public float spawnRange;

    private float positionX;
    private float positionY;


    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {        
        while(true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(spawnTime);            
        }       
    }

    private void RandomSpawn()
    {
        positionX = Random.Range(-1 * spawnRange, spawnRange);
        positionY = Random.Range(-1 * spawnRange, spawnRange);
        spawnPosition = new Vector3(positionX, positionY, 0.0f);
        Instantiate(GameObject, spawnPosition, Quaternion.identity);
    }
}
