using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ObjectMover
{
    [SerializeField] float _speed;
    [SerializeField] Transform _leftUp, _rightDown;
    [SerializeField] GameObject _singleShot;
    [SerializeField] Transform _laserPlace;

    protected override void Update()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _direction *= _speed;
        base.Update();
        _boundMovement();
        _shoot();
    }
    void _shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_singleShot, _laserPlace.position, Quaternion.identity);
        }
    }
    void _boundMovement()
    {
        if (transform.position.x > _rightDown.position.x)
        {
            transform.position = new Vector3(_rightDown.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < _leftUp.position.x)
        {
            transform.position = new Vector3(_leftUp.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.y > _leftUp.position.y)
        {
            transform.position = new Vector3(transform.position.x, _leftUp.position.y, transform.position.z);
        }
        else if (transform.position.y < _rightDown.position.y)
        {
            transform.position = new Vector3(transform.position.x, _rightDown.position.y, transform.position.z);
        }
    }
}
