using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(-_speed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(0f, 0f, -_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(0f, 0f, _speed * Time.deltaTime);
    }
}
