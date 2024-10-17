using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {

        if (Input.anyKeyDown)  //눌렀을 때
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.anyKey)  //누르고 있을 때
        {
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        }

        if (Input.GetKeyDown(KeyCode.Return))  //특정 키를 눌렀을때. (Enter)
        {
            Debug.Log("아이템을 구입하였습니다.");
        }

        if (Input.GetKey(KeyCode.LeftArrow))  //특정 키를 누르고 있을때. (->)
        {
            Debug.Log("왼쪽으로 이동 중");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))  //특정 키에서 뗐을때. (<-)
        {
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }

        //KeyCode는 ESC는 Escape, F1~12까지 그대로, 알파벳도 그대로.

        if (Input.GetMouseButtonDown(0))  //매개변수: 0은 좌클릭, 1은 우클릭
        {
            Debug.Log("미사일 발사!");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("미사일 모으는 중...");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("슈퍼 미사일 발사!!");
        }

        //  GetButton 받기 (Edit - {rogram Settings - Input Manager)

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프!");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("점프 모으는 중...");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("슈퍼 점프!!");
        }

        // Jump는 Space키임을 알 수 있다. (Input Manager 피셜)
        // Input Manager-Axe-Size를 늘리면 여러 키 Input을 더 생성할 수 있다.

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중.." + Input.GetAxis("Horizontal"));
            //  GetAxis -> GetAxisRaw 로 변경하면 좌,동시,우(-1,0,1)
            //  만 확인할 수 있다. 가중치 없음.
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중.." + Input.GetAxisRaw("Vertical"));
        }

    }

}

/*
public class LifecyclePractice : MonoBehaviour
{

    void Awake()  // 초기화 영역
    {
        Debug.Log("플레이어 테이터 준비 완료");
    }

    void OnEnable()  //게임 오브젝트 활성화 시 실행. 최초1회 아님, onoff마다
    {
        Debug.Log("플레이어 로그인 완료");
    }

    void Start()  // 초기화 영역
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() // 프레임 - 물리연산 업데이트 (고정된 실행주기로 CPU 많이 사용)
    {
        Debug.Log("이동!");  // 약 50fps
    }

    void Update()  // 프레임 - 게임로직 업데이트
    {
        Debug.Log("몬스터 사낭!");  //  약 60fps, 컴퓨터 상황에 따라 다름.
    }

    void LateUpdate()  // 모든 업데이트가 끝난 후 실행. 카메라나 로직 후처리
    {
        Debug.Log("경험치 획득.");  // 약 60fps, 컴퓨터 상황에 따라 다름.
    }

    void OnDisable()  //  게임 오브젝트 비활성화시 실행.
    {
        Debug.Log("플레이어 로그아웃 완료");
    }

    void OnDestroy()  //  게임 오브젝트 삭제하면 실행됨.
    {
        Debug.Log("플레이어 데이터 해체 완료");
    }

}
*/