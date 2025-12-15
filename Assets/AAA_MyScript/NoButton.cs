using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : MonoBehaviour
{
    [SerializeField] GameObject CheckTxt;
    [SerializeField] GameObject Yes;
    [SerializeField] GameObject No;
    [SerializeField] GameObject IF;
    [SerializeField] GameObject NameTxt;

    public void ReturnInput()
    {
        AudioManager.Instance.IsPlaySE("ƒLƒƒƒ“ƒZƒ‹‰¹");
        CheckTxt.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);
        IF.SetActive(true);
        NameTxt.SetActive(false);
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
