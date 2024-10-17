using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        //rigid.velocity = Vector3.right;  //단위벡터

        //rigid.velocity = new Vector3(2, 4, -1);  //방향지정
            //이 코드를 Update()에서 실행하면 1초에 60번 실행하므로
            //계속 벡터 방향으로 이동할 것이다.
            //그리고 RigidBody 관련 코드는 FixedUpdate에 작성!!

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
    private void OnTriggerStay(Collider other) // other은 트리거가 되는 주체임. (자기장 등)
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);
        }
    }

    // 실제 물리충돌 이벤트 -> OnCollision Enter/stay/exit (Collision collision)
    // 콜라이더 충돌 이벤트 -> OnTrigger Enter/stay/exit (Collider other)

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}


// 1. 속력 바꾸기
// rigid.velocity = Vector3.forward;

// 2. 힘을 가하기
// rigid.Addforce(Vector3.up*25, ForceMode.Impurse);

// 3. 회전력
// rigid.AddTorque(Vector3.back);