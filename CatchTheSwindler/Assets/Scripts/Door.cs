using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private BoxCollider2D _collider;
    private CapsuleCollider2D _targetCollider;
    [SerializeField] public UnityEvent _opened = new UnityEvent();

    private void Start()
    {
        _targetCollider = _target.GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _opened?.Invoke();
    }
}