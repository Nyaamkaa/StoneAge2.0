using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float radius = 1;

    public float spawnerRate = 1f;
    private float nextSpwn;

    private int randomPointIndex;
    [SerializeField] private List<Transform> spawnPoints;
    private List<int> spawnPointsIndexs = new List<int>();


    int StopSpawn = 4;


    private void Start()
    {
        
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SpawnObjectAtRandom();
        //}

        if (Time.time > nextSpwn)
        {
            SpawnObjectAtRandom();
            nextSpwn = Time.time + spawnerRate;
        }

    }

    void SpawnObjectAtRandom()
    {
        
        if (spawnPointsIndexs.Count < spawnPoints.Count)
        {

            if (spawnPointsIndexs.Count == 0)
            {
                SpawnObjact();
            }
            else
            {
                bool b = false;

                do
                {
                    randomPointIndex = Random.Range(0, spawnPoints.Count);
                    for (int i = 0; i < spawnPointsIndexs.Count; i++)
                    {
                        if (spawnPointsIndexs[i] == randomPointIndex)
                        {
                            break;
                        }
                        if (i == spawnPointsIndexs.Count - 1)
                        {

                            b = true;
                            break;

                        }
                    }
                }
                while (!b);

                SpawnObjact();

            }
            StopSpawn--;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }

    void SpawnObjact()
    {
        spawnPointsIndexs.Add(randomPointIndex);
        Vector3 randomPos = spawnPoints[randomPointIndex].position;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }

}
