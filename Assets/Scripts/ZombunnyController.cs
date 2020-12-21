using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombunnyController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _moveSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.Rotate(0, 180, 0);
    }
}
