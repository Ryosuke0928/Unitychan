using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.IsPlayBGM("IngameBGM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
