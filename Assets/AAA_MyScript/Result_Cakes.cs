using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_Cakes : MonoBehaviour
{
    public Text _resultCakeTxt;
    // Start is called before the first frame update
    void Start()
    {
        if(ScoreManager._totalCakes == 10)
        {
            _resultCakeTxt.text = "Complete";
        }
        else
        {
            _resultCakeTxt.text = ScoreManager._totalCakes.ToString() + "/10";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
