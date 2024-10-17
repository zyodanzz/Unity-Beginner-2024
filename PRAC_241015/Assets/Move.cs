using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //1. MoveTowards (�ܼ� ��� �̵�)
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);
            //�Ű������� (������ġ, ��ǥ��ġ, �ӵ�)


        //2. SmoothDamp (�̲��������� ���� �̵�)
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
            //�Ű������� (������ġ, ��ǥ��ġ, ���� �ӵ�, �ӵ�)
            //currentVelocity���� ref������ �޾Ƽ� ��� ���ŵ�.
            //�̴� taylor series 3�� �ױ��� ������ ���� �ٻ�ġ��.
            //������ �ӵ����� ���� �ӵ��� �ݺ����.


        //3. Lerp      (���� ���� �̵�) -> SmoothDamp���� ���ӽð��� ���
        transform.position =
            Vector3.Lerp(transform.position, target, 0.1f);
        */

        //4. Slerp     (���� ���� ���� �̵�) -> ȣ�� �׸��� �̵�
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);

    }
}
