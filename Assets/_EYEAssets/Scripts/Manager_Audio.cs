using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private int _birdAudioID;
    [SerializeField] private bool _isBirdAudioReady;

    [SerializeField] private AudioClip _bird01;
    [SerializeField] private AudioClip _bird02;
    [SerializeField] private AudioClip _bird03;

    [SerializeField] private AudioClip _wind;


    void Start()
    {
        _isBirdAudioReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isBirdAudioReady)
            PlayRandomBirdAudio();        
    }

    void PlayRandomBirdAudio()
    {
        Debug.Log("Bird Audio");
        _isBirdAudioReady = false;
        
        _birdAudioID = Random.Range(0, 3);

        switch(_birdAudioID)
        {
            case 0:
                _audioSource.clip = _bird01;
                break;
            case 1:
                _audioSource.clip = _bird02;
                break;
            case 2:
                _audioSource.clip = _bird03;
                break;
            default:
                break;
        }

        _audioSource.Play();

        StartCoroutine(BirdAudioTimer());
    }

    IEnumerator BirdAudioTimer()
    {
        var _birdAudioDelay = Random.Range(2, 10);
        
        yield return new WaitForSeconds(_birdAudioDelay);
        _isBirdAudioReady = true;
    }

}
