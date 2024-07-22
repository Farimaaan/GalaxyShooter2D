using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Transform _leftUp, _rightDown;
    [SerializeField] float _spawnRate;
    [SerializeField] GameObject[] _objectToSpawn;
    [SerializeField] bool _randomX, _randomY;
    int _objectIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_spawn());
    }

    IEnumerator _spawn()
    {
        float xPosition, yPosition;
        if (_randomX)
        {
            xPosition = Random.Range(_leftUp.position.x, _rightDown.position.x);
        }
        else
        {
            xPosition = transform.position.x;
        }
        if (_randomY)
        {
            yPosition = Random.Range(_leftUp.position.y, _rightDown.position.y);
        }
        else
        {
            yPosition = transform.position.y;
        }

        Vector3 spawnPosition = new Vector3(xPosition, yPosition, transform.position.z);
        yield return new WaitForSeconds(_spawnRate);

        if (_objectToSpawn.Length == 1)
        {
            Instantiate(_objectToSpawn[0], spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(_objectToSpawn[Random.Range(0, _objectToSpawn.Length)], spawnPosition, Quaternion.identity);
        }

        StartCoroutine(_spawn());
    }

}
