using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        //rigid.velocity = Vector3.right;  //��������

        //rigid.velocity = new Vector3(2, 4, -1);  //��������
            //�� �ڵ带 Update()���� �����ϸ� 1�ʿ� 60�� �����ϹǷ�
            //��� ���� �������� �̵��� ���̴�.
            //�׸��� RigidBody ���� �ڵ�� FixedUpdate�� �ۼ�!!

        //rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up*25,ForceMode.Impulse);
            //Debug.Log(rigid.velocity);
        }*/

        Vector3 vec = new Vector3(
                Input.GetAxisRaw("Horizontal"),
                0,
                Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        //rigid.AddTorque(Vector3.back);

    }
    private void OnTriggerStay(Collider other) // other�� Ʈ���Ű� �Ǵ� ��ü��. (�ڱ��� ��)
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);
        }
    }

    // ���� �����浹 �̺�Ʈ -> OnCollision Enter/stay/exit (Collision collision)
    // �ݶ��̴� �浹 �̺�Ʈ -> OnTrigger Enter/stay/exit (Collider other)

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}


// 1. �ӷ� �ٲٱ�
// rigid.velocity = Vector3.forward;

// 2. ���� ���ϱ�
// rigid.Addforce(Vector3.up*25, ForceMode.Impurse);

// 3. ȸ����
// rigid.AddTorque(Vector3.back);