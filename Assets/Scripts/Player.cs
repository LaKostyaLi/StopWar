using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float _speed = 9;
    public Transform _hands;
    public Transform _ballUp;
    public Transform _ballDown;
    public Transform _rocket;
    

    [SerializeField] Transform _target;

    private bool _isBallMe = true;
    private bool _isBallFlying = false; //будет true когда объект в полёте
    private float _t = 0; //время полёта

    Rigidbody _rb;

    private void Update()
    {
        Rigidbody _rb = GetComponent<Rigidbody>();
        _rb.constraints = RigidbodyConstraints.FreezePositionY;


        Vector3 direction = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal") * -1);
        transform.position += direction * _speed * Time.deltaTime;
        transform.LookAt(transform.position + direction);
    }
}


