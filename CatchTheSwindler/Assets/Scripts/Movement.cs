using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _body;

    [SerializeField] private float _jumpForce = 25;
    [SerializeField] private float _runSpeed = 4.55f;
    [SerializeField] private Player _player; 

    private float _vertical;
    private float _horizontal;

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        _body.velocity = new Vector2(_horizontal * _runSpeed, _vertical * _jumpForce);

        if (_player.Grounded == false)
            _jumpForce = 0;
        else         
            _jumpForce = 30;       
    }
}