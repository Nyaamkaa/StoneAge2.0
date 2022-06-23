using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject itemPrefab;
    public float radius = 1;

    public float spawnerRate = 1f;
    private float countdown;

    

    private void Start()
    {
        countdown = spawnerRate;
    }

    void Update()
    {
        countdown += Time.deltaTime;

        if(countdown >= 0)
        {
            SpawnObjectAtRandom();
            countdown = spawnerRate;
        }
       
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * radius;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
 //cделать 3 скрипт таймер в +