using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _body;
    [SerializeField] private Animator _animator;

    void FixedUpdate()
    {
        if (_body.velocity.y > 0.005f)
        {
            _animator.Play("Jump");
        }
        if (_body.velocity.x > 0f)
        {
            _animator.Play("SwinglerMove");
        }
        else if (_body.velocity.x < 0f)
        {
            _animator.Play("SwinglerMoveForward");
        }
        else if (_body.velocity.x == 0)
        {
            _animator.Play("Idle");
        }
    }
}