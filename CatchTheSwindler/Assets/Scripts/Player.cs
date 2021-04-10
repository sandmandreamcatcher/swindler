using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public bool Grounded { get; private set; }
    [SerializeField] private CapsuleCollider2D _body;
    [SerializeField] private BoxCollider2D _ground;

    private void Update()
    {
        Grounded = _body.IsTouching(_ground);
    }
}