using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Toilet : MonoBehaviour
{
    private Animator animator;
    private AudioSource _doorToilet;
    [SerializeField] private AudioClip _doorSE;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _doorToilet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key_Secret.SecretKeyGet)
        {
            animator.SetBool("open", true);
            _doorToilet.PlayOneShot(_doorSE);
            Key_Secret.SecretKeyGet = false;
        }
    }
}
