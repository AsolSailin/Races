using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cars;
    private float[] positions = { -3f, -1.5f, 0f, 1.5f, 3f };

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, positions.Length)], -6f, 0), Quaternion.Euler(new Vector3(0, 0, 90)));
        }
    }
}
