using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyParent : MonoBehaviour
{
    public static bool ParentKeyGet = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            ParentKeyGet = true;
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
