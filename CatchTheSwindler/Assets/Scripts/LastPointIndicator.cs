using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LastPointIndicator : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _reached?.Invoke();
    }
}
