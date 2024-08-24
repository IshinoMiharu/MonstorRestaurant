using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class CharacterActionBase : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;

    [SerializeField]
    float _moveSpeed = 5;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 0;
    }

    public void Moving(Vector2 axis)
    {
        _rigidbody2D.velocity = axis.normalized * _moveSpeed;
    }
}
