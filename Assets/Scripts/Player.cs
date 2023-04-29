using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _canvas;
    private float speed = 5f;
    private Vector3 offset;

    void Update()
    {
        /*Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;*/

        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(0, hor, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Destroy(gameObject);
            Time.timeScale = 0.0f;
            _canvas.SetActive(true);
        }
    }

    /*[SerializeField]
    private GameObject _canvas;
    private Vector3 _destination;
    private bool _turning;

    void Update()
    {
        if (!_turning) return;
        transform.position = Vector3.MoveTowards(transform.position, _destination, 5 * Time.deltaTime);
        if (Math.Abs(transform.position.x - _destination.x) < 1e-6)
            _turning = false;
    }
    public void Turn(Direction direction)
    {
        if (_turning) return;
        _destination = new Vector3(transform.position.x + (direction == Direction.Left ? -2 : 2),
            transform.position.y, transform.position.z);
        _turning = true;
    }*/
}
