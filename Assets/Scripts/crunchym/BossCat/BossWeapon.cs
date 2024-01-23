using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    [SerializeField]
    public Transform firePoint;
    [SerializeField]
    public GameObject bulletPrefab;
    //[SerializeField]
    //public GameObject _enemyPrefab;
    [SerializeField]
    private float _minimumSpawnTime;
    [SerializeField]
    private float _maximumSpawnTime;
    [SerializeField]
    private float _timeUntilSpawn;

    private void Shoot()
    {
        //shooting logic goes here
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            SetTimeUntilSpawn();
        }
    }
    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
