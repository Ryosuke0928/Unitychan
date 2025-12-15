using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetName : MonoBehaviour
{
    public InputField inputField;
    [SerializeField] GameObject CheckTxt;
    [SerializeField] GameObject Yes;
    [SerializeField] GameObject No;
    [SerializeField] GameObject NT;
    [SerializeField]Text Nametxt;
    [SerializeField] GameObject IF;
    public static string _name;

    private void OnInputEnd(string inputText)
    {
        if (!string.IsNullOrEmpty(inputText))
        {
            AudioManager.Instance.IsPlaySE("ボタンクリック");
            CheckTxt.SetActive(true);
            Yes.SetActive(true);
            No.SetActive(true);
            NT.SetActive(true);
            Nametxt.text = inputField.text;
            _name = inputText;
            IF.SetActive(false);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        inputField.onEndEdit.AddListener(OnInputEnd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
