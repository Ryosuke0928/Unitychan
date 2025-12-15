using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Cakes : MonoBehaviour
{
    public Text cakeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        cakeText.text = ScoreManager._totalCakes.ToString() + "/10";
    }
}
