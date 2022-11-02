using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayer_script : MonoBehaviour
{
    [SerializeField] private GameObject _recordPlatter;
    [SerializeField] private GameObject _playerNeedle;
    [SerializeField] private float _recordRotationSpeed = 2;
    [SerializeField] private bool _isPlaying;
    
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _audioLibrary;
    [SerializeField] private int _audioTrack;

    void Start()
    {
        
    }

    void Update()
    {
        if(_isPlaying == true)
        {
            _recordPlatter.transform.Rotate(0, _recordRotationSpeed, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isPlaying = !_isPlaying;
        if(other.tag == "Player" && _isPlaying == false)
        {
            Debug.Log("Entered");

            _playerNeedle.transform.Rotate(0, 30, 0);
            _audioSource.clip = _audioLibrary[_audioTrack];

            _audioSource.Play();
        }
        else if(other.tag == "Player" && _isPlaying ==true)
        {
            _audioSource.Stop();

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Here I am");
            if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                _audioTrack++;
                if(_audioTrack > _audioLibrary.Length)
                {
                    _audioTrack = 0;
                }
                _audioSource.clip = _audioLibrary[_audioTrack];
                _audioSource.Play();
            }
        }
    }

}
