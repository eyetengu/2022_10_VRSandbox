using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Script : MonoBehaviour
{
    [SerializeField] private int _score, _redScore, _greenScore, _blueScore;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private bool _isRedTarget, _isGreenTarget, _isBlueTarget;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile_Red" && _isRedTarget) 
        {
            other.transform.SetParent(transform);
            _score++;
            _redScore++;
        }
        if (other.tag == "Projectile_Green" && _isGreenTarget)
        {
            other.transform.SetParent(transform);
            _score++;
            _greenScore++;

        }
        if (other.tag == "Projectile_Blue" && _isBlueTarget)
        {
            other.transform.SetParent(transform);
            _score++;
            _blueScore++;
        }
    }
}
