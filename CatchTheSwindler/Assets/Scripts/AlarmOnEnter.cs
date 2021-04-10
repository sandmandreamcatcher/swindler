using UnityEngine;

public class AlarmOnEnter : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _collider;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private GameObject _target;
    [SerializeField] private Door _door;

    private CapsuleCollider2D _targetCollider;
    private float _volumeStep = 0.1f;

    private void Start()
    {
        _target.TryGetComponent<CapsuleCollider2D>(out _targetCollider);
    }

    private void FixedUpdate()
    {
        if (_collider.IsTouching(_targetCollider))
        {
            if (_door.IsOpen)
                _audio.mute = false;

            _audio.volume = Mathf.InverseLerp(_collider.radius, _target.transform.position.x, _volumeStep);
            if (_target.transform.position.x > _collider.transform.position.x)
                _audio.volume = Mathf.InverseLerp(-_collider.radius, _target.transform.position.x, _volumeStep);
        }
        else
        {
            _audio.mute = true;
        }
    }
}