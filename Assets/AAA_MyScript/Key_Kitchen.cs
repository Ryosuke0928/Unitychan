using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Kitchen : MonoBehaviour
{
    public static bool KitchenKeyGet = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            KitchenKeyGet = true;
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
