using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerbody;
    [SerializeField] private Collider2D[] _colliderArray = new Collider2D[1];
    [SerializeField] private ContactFilter2D _colliderFilter;
    [Range(1, 10)] [SerializeField] private float _moveSpeed;
    [Range(10, 50)] [SerializeField] private float _jumpForce;

    private void FixedUpdate()
    {
        bool isGrounded = System.Convert.ToBoolean(_playerbody.GetContacts(_colliderFilter, _colliderArray));
        float xVelocity = 0f;
        float yVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
            xVelocity = 1f * _moveSpeed;

        if (Input.GetKey(KeyCode.A))
            xVelocity = -1f * _moveSpeed;

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && isGrounded)
        {
            yVelocity = 2.2f;
            Vector2 force = new Vector2(xVelocity, (yVelocity *= _jumpForce));
            _playerbody.AddForce(force, ForceMode2D.Impulse);
        }

        _playerbody.velocity = new Vector2(xVelocity, yVelocity);
    }
}