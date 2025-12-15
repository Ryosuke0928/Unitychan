using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBedRoom : MonoBehaviour
{
    private Animator animator;
    private AudioSource _doorBed;
    [SerializeField] private AudioClip _doorSE;
    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>();
        _doorBed = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key_Bed.BedKeyGet)
        {
            animator.SetBool("open",true);
            _doorBed.PlayOneShot(_doorSE);
            Key_Bed.BedKeyGet = false;
        }
    }
}
