using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerTurn : MonoBehaviour
{
    [SerializeField] private int _degRot = 45;
    [SerializeField] private Camera _camera;

    void Start()
    {
    }

    void Update()
    {
        //SNAP TURN ALTERNATIVE
        //Rotate 90' Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, -1 * _degRot, 0);
        }
        //Rotate 90' Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, _degRot * 1, 0);
        }
        //Rotate 180'
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(0, 180, 0);
        }

        //FIELD OF VIEW
        //Increase Field Of View
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            _camera.fieldOfView += 10;
            if (_camera.fieldOfView > 120)
            { _camera.fieldOfView = 120; }
        }
        //Decrease Field Of View
        if(Input.GetKeyDown(KeyCode.LeftBracket))
        {
            _camera.fieldOfView -= 10;
        }
        if (_camera.fieldOfView < 60)
        { _camera.fieldOfView = 60; }




    }



}
