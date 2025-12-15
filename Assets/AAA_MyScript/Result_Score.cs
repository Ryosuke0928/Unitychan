using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_Score : MonoBehaviour
{
    public Text _resultScore;
    // Start is called before the first frame update
    void Start()
    {
        _resultScore.text = "Score:" + ScoreManager._totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
