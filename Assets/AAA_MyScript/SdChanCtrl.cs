using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SdChanCtrl : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    [SerializeField]
    private float walkSpeed = 3f;

    [SerializeField]
    private float runSpeed = 5f;

    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private float jumpForce;

    public float moveForward;
    public float rotation;

    private bool IsGround;
    public bool isJumping = false;

    private Rigidbody rb;
    private BoxCollider col;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            IsGround = true;
            isJumping = false;
            animator.SetBool("isJump",false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            IsGround = true;
            isJumping = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            IsGround = false;
            isJumping = true;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if((HpController._hp != 0 && Text_Timer._time != 0) && !animator.GetBool("isDamage"))
        {
            moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(Vector3.forward * moveForward);

            rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * rotation);

            Jump();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = runSpeed;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = walkSpeed;
            }
        }
        
        if(moveForward != 0 || rotation != 0)
        {
            animator.SetBool("isWalk",true);
        }
        if(moveForward == 0 &&  rotation == 0)
        {
            animator.SetBool("isWalk",false);
        }


        if(Input.GetKeyDown(KeyCode.LeftShift) && (moveForward != 0 || rotation != 0))
        {
            animator.SetBool("isRun", true);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("isRun",false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGround && !isJumping)
        {
            isJumping = true;
            animator.SetBool("isJump", true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        

    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGround && !isJumping)
        {
            AudioManager.Instance.IsPlaySE("ƒWƒƒƒ“ƒv");
            isJumping = true;
            animator.SetBool("isJump", true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

}
    

    


