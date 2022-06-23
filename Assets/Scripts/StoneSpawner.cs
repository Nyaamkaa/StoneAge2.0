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

//1. ��������� ������,���� �� ������ �� �������(�� ����� �������) ��������� �� ���,�� ���������
//2. ����������� ������� ������,����� ����� ������������(����� ������ �����)
//3. ����������� �������,������� ��� ��� � ������ ������ � ���� ��������(�������� �� ���)
//4. ������� ������ ����� ������,������� �������� ��� ������� � ������. ����� ��������� ������� ����� ������������ ������� �� ������(���� �� ������ ��� �����,� ����� �������� �������� ������ � �������������� ������)
//5. ��������� � ������� � ��������� ������� ������ �� ������ ������� (DesctructableObjact2D)
