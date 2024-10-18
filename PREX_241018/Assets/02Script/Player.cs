using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManagerLogic manager;

    Rigidbody rigid;
    bool isJump;
    AudioSource audioWhenGetItem;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audioWhenGetItem = GetComponent<AudioSource>();
    }

    void Update()
    {
       if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0,jumpPower,0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            isJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            other.gameObject.SetActive(false);
            itemCount++;
            audioWhenGetItem.Play();
            manager.GetItem(itemCount);
        }
        else if (other.tag == "Finish")
        {
            if (itemCount == manager.totalItemCount)
            {
                if (manager.stage == 1)
                {
                    SceneManager.LoadScene(0);
                }
                else SceneManager.LoadScene("Example1_" + (manager.stage+1).ToString());
            }
            else
            {
                //Restart!
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
