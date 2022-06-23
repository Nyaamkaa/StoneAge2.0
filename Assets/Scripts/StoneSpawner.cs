using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
   
    public float spawnerRate = 1f;
    private float nextSpawn;

    private float randomX;
    public Vector2 whereToSpawn;


    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnerRate;
            randomX = Random.Range(1f, 23.5f);
            whereToSpawn = new Vector2(randomX, transform.position.y);

            SpawnStone();
        }
    }

    private void SpawnStone()
    {
       ObjectPooler.objectPooler.GetPoolObject().SetActive(true);
      

    }
}

//1. Исправить ошибку,Если не ИсГров не активен(не стоит галочка) проверить на нул,до активации
//2. Зарандомить позицию спавна,между двумя координатами(между краями карты)
//3. Зарандомить поворот,изменяя его уже в момент спавна и силу кручения(ротатион по зет)
//4. Создать внутри камня таймер,который стартует при касании с землей. после окончания тамйера камню активировать голочку ис тригер(чтоб он уходит под землю,а когда скроется выгулить тригер и деактивировать объект)
//5. Заглянуть в фотошом и попбовать разбить камень на мелкие камушки (DesctructableObjact2D)
