using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    [SerializeField]
    private GameObject road;
    private float speed = 10f;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -16.5f)
        {
            Instantiate(road, new Vector3(0f, 25.7f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
