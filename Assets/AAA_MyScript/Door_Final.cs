using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Final : MonoBehaviour
{
    private Animator animator;
    private AudioSource _doorFinal;
    [SerializeField] private AudioClip _doorSE;
    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>();
       _doorFinal = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key_Toilet.ToiletKeyGet)
        {
            animator.SetBool("open", true);
            _doorFinal.PlayOneShot(_doorSE);
            Key_Toilet.ToiletKeyGet = false;
        }
    }
}
