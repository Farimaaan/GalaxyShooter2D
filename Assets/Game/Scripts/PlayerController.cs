using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 _direction;
    [SerializeField] float _speed;
    [SerializeField] ObjectMover _mover;
    // Update is called once per frame
    void Update()
    {
        _move();
    }
    void _move()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _direction *= _speed * Time.deltaTime;
        //_mover._Move(_direction);
    }
}
