using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Unity : MonoBehaviour
{
    public Image displayU;
    public Sprite[] UnichaImage; 
    // Start is called before the first frame update
    void Start()
    {
        ShowRandomUnitychcan();
    }

    void ShowRandomUnitychcan()
    {
        int _randomIndex = Random.Range(0, UnichaImage.Length);
        displayU.sprite = UnichaImage[_randomIndex];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
