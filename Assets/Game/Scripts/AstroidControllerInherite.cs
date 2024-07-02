using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidControllerInherite : ObjectMover
{
    [SerializeField] Vector2 _direction;

    // Update is called once per frame
    void Update()
    {
        //_Move(_direction * Time.deltaTime);
    }
}
