using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Intersection_script : MonoBehaviour
{
    [SerializeField] private string _nsStreet;
    [SerializeField] private string _ewStreet;
    [SerializeField] private Text _streetInfoText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _streetInfoText.text = _ewStreet + " & " + _nsStreet;
        }
    }
}
