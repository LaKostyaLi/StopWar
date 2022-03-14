using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 15;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private FixedJoystick _joystick;
   
    
    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * _speed, _rb.velocity.y, _joystick.Vertical * _speed);
        if(_joystick.Horizontal !=0 || _joystick.Vertical!=0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
        }
    }
}


