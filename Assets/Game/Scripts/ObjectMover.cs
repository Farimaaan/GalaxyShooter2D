using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] protected Vector2 _direction;

    protected void _Move()
    {
        transform.Translate(_direction * Time.deltaTime);
    }
    protected virtual void Update()
    {
        _Move();
    }

}
