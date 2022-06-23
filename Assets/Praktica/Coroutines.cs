using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public GameObject itemPrefab;
    public float radius = 100;

    public float spawnerRate = 0.1f;
    private float countdown;



    private void Start()
    {
        StartCoroutine(SpawnObjectAtRandom());
    }


    IEnumerator SpawnObjectAtRandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnerRate);
            Vector3 randomPos = Random.insideUnitCircle * radius;
            GameObject itemObject = Instantiate(itemPrefab, randomPos, Quaternion.identity);
            StartCoroutine(HideObjact(itemObject));
        }
    }

    IEnumerator HideObjact(GameObject itemObject)
    {
        yield return new WaitForSeconds(3f);
        itemObject.SetActive(false);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
