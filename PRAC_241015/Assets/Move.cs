using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //1. MoveTowards (단순 등속 이동)
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);
            //매개변수는 (현재위치, 목표위치, 속도)


        //2. SmoothDamp (미끄러지듯이 감속 이동)
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
            //매개변수는 (현재위치, 목표위치, 참조 속도, 속도)
            //currentVelocity값을 ref참조로 받아서 계속 갱신됨.
            //이는 taylor series 3차 항까지 전개한 지수 근사치임.
            //마지막 속도값은 실제 속도에 반비례함.


        //3. Lerp      (선형 보간 이동) -> SmoothDamp보다 감속시간이 길다
        transform.position =
            Vector3.Lerp(transform.position, target, 0.1f);
        */

        //4. Slerp     (구면 선형 보간 이동) -> 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);

    }
}
