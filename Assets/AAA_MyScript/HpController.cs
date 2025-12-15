using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : MonoBehaviour
{
    [SerializeField] GameObject[] HP = new GameObject[3];
    Animator animator;
    public static int _hp = 3;

    public float _airTime;
    private bool _isGround;
    // Start is called before the first frame update
    void Start()
    {
        _hp = 3;
        _airTime = 0;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Obstacle") && _hp == 3)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage",true);
            HP[0].SetActive(false);
            _hp = 2;
        }

        else if(collision.gameObject.CompareTag("Obstacle") && _hp == 2)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage", true);
            HP[1].SetActive(false);
            _hp = 1;
        }
        else if(collision.gameObject.CompareTag("Obstacle") && _hp == 1)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage", true);
            HP[2].SetActive(false);
            _hp = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Mashroom") && _hp == 3)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage", true);
            HP[0].SetActive(false);
            _hp = 2;
        }
        else if(other.CompareTag("Mashroom") && _hp == 2)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage", true);
            HP[1].SetActive(false);
            _hp = 1;
        }
        else if(other.CompareTag("Mashroom") && _hp == 1)
        {
            AudioManager.Instance.IsPlaySE("被ダメ");
            AudioManager.Instance.IsPlaySE("被ダメージボイス");
            animator.SetBool("isDamage", true);
            HP[2].SetActive(false);
            _hp = 0;
        }


        if (other.gameObject.CompareTag("Ground"))
        {
            _isGround = true;

            if (_airTime > 1.5 && _hp == 3)
            {
                AudioManager.Instance.IsPlaySE("被ダメ");
                AudioManager.Instance.IsPlaySE("被ダメージボイス");
                animator.SetBool("isDamage", true);
                HP[0].SetActive(false);
                _hp = 2;
            }
            else if(_airTime > 1.5 && _hp == 2)
            {
                AudioManager.Instance.IsPlaySE("被ダメ");
                AudioManager.Instance.IsPlaySE("被ダメージボイス");
                animator.SetBool("isDamage", true);
                HP[1].SetActive(false);
                _hp = 1;
            }
            else if(_airTime > 1.5 && _hp == 1)
            {
                AudioManager.Instance.IsPlaySE("被ダメ");
                AudioManager.Instance.IsPlaySE("被ダメージボイス");
                animator.SetBool("isDamage", true);
                HP[2].SetActive(false);
                _hp = 0;
            }
        }

        _airTime = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _airTime = 0;
            _isGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGround = false;
        }
    }
    public void OnDamageEnd()
    {
        animator.SetBool("isDamage", false);
    }

    
    // Update is called once per frame
    void Update()
    {
        if (!_isGround)
        {
            _airTime += Time.deltaTime;
        }
    }
}
