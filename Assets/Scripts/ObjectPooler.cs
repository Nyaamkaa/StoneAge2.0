using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler objectPooler {get; private set;}
    [SerializeField] private GameObject poolObject;
    private List<GameObject> poolObjects;
    [SerializeField] private int poolSize;
    [SerializeField] private bool willGrow;
    private StoneSpawner stoneSpawner;


    

    private float randomX;
    //Vector2 whereToSpawn;

    private void Awake()
    {
        if(objectPooler == null)
        {
            objectPooler = this;
        }
        else
        {
            Destroy(objectPooler);
        }
        poolObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            poolObjects.Add(Instantiate(poolObject));
            poolObjects[i].transform.SetParent(transform);
            poolObjects[i].SetActive(false);
        }
        stoneSpawner = GetComponent<StoneSpawner>();
        
    }

    private void Update()
    {
        poolObject.transform.position = stoneSpawner.whereToSpawn;
    }

    public GameObject GetPoolObject()
    {
       


        for (int i = 0; i < poolObjects.Count; i++)
        {
          if(!poolObjects[i].activeInHierarchy)
          {
                return poolObjects[i];
          }
        } 

        if(willGrow)
        {
            GameObject obj = Instantiate(poolObject);
            obj.SetActive(false);
            obj.transform.SetParent(transform);
            poolObjects.Add(obj);
            return obj;

        }
        return null;

        
    }
  
}
