using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    private int _cakeScore = 120;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.IsPlaySE("ケーキ");
            AudioManager.Instance.IsPlaySE("ナイス！");
            Destroy(gameObject);
            ScoreManager._totalScore += _cakeScore;
            ScoreManager._totalCakes += 1;
            Text_Timer._time += 20f;

            if (ScoreManager._totalCakes == 5)
            {
                Text_Timer._time += 20f;
            }
        }
        
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
