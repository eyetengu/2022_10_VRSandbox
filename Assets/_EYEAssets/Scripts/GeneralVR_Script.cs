using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class GeneralVR_Script : MonoBehaviour
{
    //GENERAL
    [SerializeField] private Transform _xrRigTransform;
    [SerializeField] private int _degRot = 45;
    
    //SOCKETS
    [SerializeField ]private XRSocketInteractor _socket_Red;
    [SerializeField] private XRSocketInteractor _socket_Green;
    [SerializeField] private XRSocketInteractor _socket_Blue;

    //Projectile Bools
    [SerializeField] private bool _isLoaded_Red ;
    [SerializeField] private bool _isLoaded_Green;
    [SerializeField] private bool _isLoaded_Blue;
    [SerializeField] private Transform _firingTransform01;
    //[SerializeField] private Transform _firingTransform02;    //chest Transform
    [SerializeField] private Transform _firingTransform03;    //shoulder Transform

    //PROJECTILE DATA
    [SerializeField] private GameObject _projectilePrefabRed, _projectilePrefabGreen, _projectilePrefabBlue;
    [SerializeField] private bool _isProjectileA, _isProjectileB, _isProjectileC;
    [SerializeField] private int _projectileID;
    [SerializeField] private string[] _projectiles = { "bullet", "missile", "mortar" };
    [SerializeField] private TMP_Text _projectileText;

    //AUDIO
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _outOfAmmo;

    void Start()
    {
    }

    void Update()
    {
        //ChangeProjectile
        if(Input.GetKeyDown (KeyCode.Q))
        { 
            _projectileID++;
            if (_projectileID > 2)
                _projectileID = 0;
        }

        //Fire Projectile
        if(Input.GetKeyDown(KeyCode.Z))
        {          
            FireProjectile(_projectileID);
        }

        //Socket Null Checkers
        IXRSelectInteractable objName_Red = _socket_Red.GetOldestInteractableSelected();
        if(objName_Red != null)
        {
            //Debug.Log(objName.transform.name + " in Socket of " + transform.name);
            _isLoaded_Red = true;
        }
        IXRSelectInteractable objName_Green = _socket_Green.GetOldestInteractableSelected();
        if(objName_Green != null)
        {
            _isLoaded_Green = true;            
        }
        IXRSelectInteractable objName_Blue = _socket_Blue.GetOldestInteractableSelected();
        if (objName_Blue != null)
        {
            _isLoaded_Blue = true;            
        }

        //Rotate Left/Right
        if (Input.GetKeyDown(KeyCode.A))
        {
            _xrRigTransform.Rotate(0, -1 * _degRot, 0);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            _xrRigTransform.Rotate(0, _degRot * 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            _xrRigTransform.Rotate(0, 180, 0);
        }


        //Quit Application
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void FireProjectile(int projectileCode)
    {
        switch(_projectileID)
        {
            case 0:
                Instantiate(_projectilePrefabRed, _firingTransform01.position, _firingTransform01.rotation);
                    break;
            case 1:
                Instantiate(_projectilePrefabGreen, _firingTransform01.position, _firingTransform01.rotation);
                    break;
            case 2:
                Instantiate(_projectilePrefabBlue, _firingTransform03.position, _firingTransform03.rotation);
                    break;
            default:
                _audioSource.clip = _outOfAmmo;
                _audioSource.Play();
                    break;
        }
        _projectileText.text = _projectiles[_projectileID];

    }
}
