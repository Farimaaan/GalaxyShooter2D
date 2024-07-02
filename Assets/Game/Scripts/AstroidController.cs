using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidController : MonoBehaviour
{
    [SerializeField] ObjectMover _mover;
    [SerializeField] Vector2 _direction;

    private void Update()
    {
        //_mover._Move(_direction * Time.deltaTime);
    }

}
