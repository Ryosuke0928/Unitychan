using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject startB;
    [SerializeField] private GameObject nameField;
    public void OnClickButton()
    {
        AudioManager.Instance.IsPlaySE("ボタンクリック");
        startB.SetActive(false);
        nameField.SetActive(true);
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
