using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorParentR : MonoBehaviour
{
    private Animator animator;
    private AudioSource _doorParent;
    [SerializeField] private AudioClip _doorSE;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _doorParent = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyParent.ParentKeyGet)
        {
            animator.SetBool("open",true);
            _doorParent.PlayOneShot(_doorSE);
            KeyParent.ParentKeyGet = false;
        }
    }
}
