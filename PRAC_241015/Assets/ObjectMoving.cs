using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoving : MonoBehaviour
{
    //������Ʈ �����̱�
    void Start()
    {
        /*
        Vector3 vec = new Vector3(0, 0, 0); // ���� ��.
                                            // (0,0,0)��ŭ �̵���=�״��.
        transform.Translate(vec);
        */
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime, 
            Input.GetAxis("Vertical") * Time.deltaTime, 
            0);
        // new Vector3(0,0.1f,0); -> ��� ���� �ö�.
        // GetAxisRaw���� �������� �׻� +1 or -1 �̴�.
        // deltatime�� ���ؼ� ��ǻ�Ͱ� fps���� ������ �ؼ�(��������->������)
        transform.Translate(vec);
    }

}
