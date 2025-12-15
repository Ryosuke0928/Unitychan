using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Timer : MonoBehaviour
{
    public Text timerText;
    public static float _time;
    private Color _normal;

    // Start is called before the first frame update
    void Start()
    {
        _time = 300f;
        _normal = timerText.color;
        UpdateTimerText();

    }

    // Update is called once per frame
    void Update()
    {
        if(_time > 0)
        {
            _time -= Time.deltaTime;
            UpdateTimerText();

            if(_time <= 10)
            {
                timerText.color = Color.red;
            }
            else
            {
                timerText.color = _normal;
            }
        }
        else if(_time < 0)
        {
            AudioManager.Instance.IsPlaySE("‚ ‚ç‚çŽc”O");
            _time = 0;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        int min = Mathf.FloorToInt(_time / 60);
        int sec = Mathf.FloorToInt(_time % 60);

        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
