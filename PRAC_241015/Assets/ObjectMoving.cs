using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoving : MonoBehaviour
{
    //오브젝트 움직이기
    void Start()
    {
        /*
        Vector3 vec = new Vector3(0, 0, 0); // 벡터 값.
                                            // (0,0,0)만큼 이동함=그대로.
        transform.Translate(vec);
        */
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime, 
            Input.GetAxis("Vertical") * Time.deltaTime, 
            0);
        // new Vector3(0,0.1f,0); -> 계속 위로 올라감.
        // GetAxisRaw쓰면 증감값이 항상 +1 or -1 이다.
        // deltatime을 곱해서 컴퓨터간 fps차이 문제를 해소(고프레임->작은값)
        transform.Translate(vec);
    }

}
