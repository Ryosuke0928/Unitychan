using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IF_GetName : MonoBehaviour
{
    [SerializeField] public Text _nameTxt;
    // Start is called before the first frame update
    void Start()
    {
        _nameTxt.text = GetName._name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
