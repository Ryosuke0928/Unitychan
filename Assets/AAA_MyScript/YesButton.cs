using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YesButton : MonoBehaviour
{
    public void GameStart()
    {
        AudioManager.Instance.IsPlaySE("ボタンクリック");
        AudioManager.Instance.IsPlaySE("始めるとしますか！");
        AudioManager.Instance.IsStopBGM();
        SceneManager.LoadScene("MainGameScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
