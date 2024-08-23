using UnityEngine;
using TMPro;


public class SpawnBlocks : MonoBehaviour
{
    [SerializeField] private GameObject _block;
    [SerializeField] private float _maxX;
    [SerializeField] public  int _spawnRate;

    public  void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.1f, _spawnRate);
    }
     private void SpawnBlock()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(-_maxX, _maxX);
        Instantiate(_block, spawnPos, Quaternion.identity);
    }
}
