using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    /*
    private void OnCollisionEnter(Collision collision)  // collision �浹���� Ŭ����
    {
        mat.color = new Color(0, 0, 0);  //�ٴڰ� ��Ƶ� �ٲ�
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "MyBall")
        mat.color = new Color(0, 0, 0);  //�ٴڰ� ��Ƶ� �ٲ�
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
            mat.color = new Color(1, 1, 1);  //�ٴڰ� ��Ƶ� �ٲ�
    }

    

}
