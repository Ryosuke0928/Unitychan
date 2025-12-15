using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public int _point;
    public static string[] _ranking = { "No1", "No2", "No3", "No4", "No5" };
    public static int[] _rankingIndex = new int [5];

    [SerializeField, Header("表示させるテキスト")] 
    public  Text[] _rankingTxt = new Text[5]; 
    
    public GameObject _backGround;
    private bool _isOnOff = false;
    // Start is called before the first frame update
    void Start()
    {
        _point = ScoreManager._totalScore;
        GetRanking();
        SetRanking(_point);

        InputRankingTxt();
    }

    public void InputRankingTxt()
    {
        for (int i = 0; i < _rankingTxt.Length; i++)
        {
            _rankingTxt[i].text = _rankingIndex[i].ToString();
        }
    }

    public void OutputRanking()
    {
        _isOnOff = !_isOnOff;
        if (_isOnOff)
        {
            _backGround.SetActive(true);
        }
        else
        {
            _backGround.SetActive(false);
        }
    }

    static public void GetRanking()
    {
        for(int i = 0;i< _ranking.Length;i++)
        {
            _rankingIndex[i] = PlayerPrefs.GetInt(_ranking[i]);
        }
    }

    static public void SetRanking(int _point)
    {
        for(int i = 0; i < _ranking.Length; i++)
        {
            if(_point > _rankingIndex[i])
            {
                var change = _rankingIndex[i];
                _rankingIndex[i] = _point;
                _point = change;
            }
        }

        for(int i = 0; i < _ranking.Length; i++)
        {
            PlayerPrefs.SetInt(_ranking[i], _rankingIndex[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
