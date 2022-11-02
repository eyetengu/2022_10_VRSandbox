using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRProjectile_Script : MonoBehaviour
{
    [SerializeField] private int _speed = 5;
    [SerializeField] private bool _isSmoke;

    void Update()
    {
        if (_isSmoke == true)
        {
            //transform.Rotate(-90, 0, 0);
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        else
        {        
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            Destroy(gameObject, 2);
        }

    }
}
