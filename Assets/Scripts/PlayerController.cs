using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour
{
    //Movement
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;


    [SerializeField] private float _moveSpeed;


    //Movement
    private void FixedUpdate()
    {


        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);


        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("Demo", true);
        }
        else
            _animator.SetBool("Demo", false);

    }

    //Coin
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has a tag of "Coin"
        if (other.gameObject.CompareTag("Coin"))
        {
            // Destroy the other object
            Destroy(other.gameObject);

            // Increase the scale of this object
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

            // Add point to score
            ScoreManager.instance.Addpoint();
        }
    }
}
