using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerInherite : ObjectMover
{
    [SerializeField] float _speed;
    
    void Update()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _direction *= _speed * Time.deltaTime;
        _Move();
    }
}
