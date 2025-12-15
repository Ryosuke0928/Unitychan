using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpCtrl : MonoBehaviour
{
    [SerializeField] GameObject _TimeUptxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Text_Timer._time == 0)
        {
            _TimeUptxt.SetActive(true);
        }
    }
}
