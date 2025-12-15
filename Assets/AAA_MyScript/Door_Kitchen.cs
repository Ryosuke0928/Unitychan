using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Kitchen : MonoBehaviour
{
    private Animator animator;
    private AudioSource _doorK;
    [SerializeField] private AudioClip _doorSE;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _doorK = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key_Kitchen.KitchenKeyGet)
        {
            animator.SetBool("open",true);
            _doorK.PlayOneShot(_doorSE);
            Key_Kitchen.KitchenKeyGet = false;
        }
    }
}
