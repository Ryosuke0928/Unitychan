using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    //特にstaticの意味ないかも
    public static int _cookieScore = 40;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.IsPlaySE("クッキー");
            Destroy(gameObject);
            ScoreManager._totalScore += _cookieScore;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
