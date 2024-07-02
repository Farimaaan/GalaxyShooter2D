using UnityEngine;

public class ObjectMover : MonoBehaviour
{

    protected Vector2 _direction;
    protected void _Move()
    {
        transform.Translate(_direction);
    }
    
}
