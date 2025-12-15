using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverCtrl : MonoBehaviour
{
    [SerializeField] GameObject _gameOverTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(HpController._hp == 0)
        {
            _gameOverTxt.SetActive(true);
        }
    }
}
