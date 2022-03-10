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


   
    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal") * -1);
        transform.position += direction * _speed * Time.deltaTime;
        transform.LookAt(transform.position + direction);

        if (_isBallMe)
        {
            if (Input.GetKey(KeyCode.R))
            {
                _rocket.position = _ballUp.position;
              //_hands.localEulerAngles = Vector3.right * 180;

                transform.LookAt(_target.position);

            }
            else
            {
                _hands.localEulerAngles = Vector3.right * 0;
                _rocket.position = _ballDown.position + Vector3.up * Mathf.Abs(Mathf.Sin(Time.time * 3));//для того чтобы прыгал (нужно Abs значение) 
            }
            if (Input.GetKey(KeyCode.R))
            {
                _isBallMe = false;
                _isBallFlying = true;
                _t = 0;

            }
        }

        if (_isBallFlying)  //полёт мяча
        {
            _t += Time.deltaTime;
            float duration = 1f;
            float t01 = _t / duration;

            Vector3 a = _ballUp.position;
            Vector3 b = _target.position;
            Vector3 pos = Vector3.Lerp(a, b, t01);

            Vector3 arc = Vector3.up * 5 * Mathf.Sin(t01 * 3.14f); //добавляем движение по дуге

            _rocket.position = pos + arc;

            
            if (t01 >= 1)
            {
                _isBallFlying = false;
                _rocket.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other) //поднимаем с пола
    {
        if (other.tag == "Rocket")
      //if (!_isBallMe && !_isBallFlying)
        {
            _isBallMe = true;
            _rocket.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}


