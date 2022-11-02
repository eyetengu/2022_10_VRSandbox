using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyntyTownXRRig_script : MonoBehaviour
{
    [SerializeField] private int _degRot = 45;

    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, -1 * _degRot, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, _degRot * 1, 0);
        }
        
    }
}
