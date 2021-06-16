using UnityEngine;

public class AlarmOnEnter : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _collider;
    [SerializeField] public AudioSource _audio;

    private void OnTriggerEnter2D(Collider2D collision)
    {  
            _audio.Play();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       _audio.volume = Mathf.Clamp01(1 - Vector2.Distance(collision.transform.position, transform.position) / _collider.radius);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _audio.Stop();
    }
}