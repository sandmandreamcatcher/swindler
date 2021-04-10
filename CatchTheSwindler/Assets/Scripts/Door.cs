using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private BoxCollider2D _collider;
    private CapsuleCollider2D _targetCollider;
    public bool IsOpen { get; private set; }

    private void Start()
    {
        _targetCollider = _target.GetComponent<CapsuleCollider2D>();
    }

    private void FixedUpdate()
    {
        IsOpen = _collider.IsTouching(_targetCollider);
    }
}