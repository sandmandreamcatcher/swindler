using UnityEngine;

public class AlarmOnEnter : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _collider;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private GameObject _target;
    private CapsuleCollider2D _targetCollider;

    private void Start()
    {
        _target.TryGetComponent<CapsuleCollider2D>(out _targetCollider);
    }

    private void FixedUpdate()
    {
        _audio.volume = Mathf.InverseLerp(_collider.transform.position.magnitude, 0, (_collider.transform.position - _target.transform.position).magnitude);

        if (_collider.IsTouching(_targetCollider))
            _audio.enabled = true;
        else
        _audio.enabled = false;
    }
}