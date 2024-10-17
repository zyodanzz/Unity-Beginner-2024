using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {

        if (Input.anyKeyDown)  //������ ��
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }

        if (Input.anyKey)  //������ ���� ��
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }

        if (Input.GetKeyDown(KeyCode.Return))  //Ư�� Ű�� ��������. (Enter)
        {
            Debug.Log("�������� �����Ͽ����ϴ�.");
        }

        if (Input.GetKey(KeyCode.LeftArrow))  //Ư�� Ű�� ������ ������. (->)
        {
            Debug.Log("�������� �̵� ��");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))  //Ư�� Ű���� ������. (<-)
        {
            Debug.Log("������ �̵��� ���߾����ϴ�.");
        }

        //KeyCode�� ESC�� Escape, F1~12���� �״��, ���ĺ��� �״��.

        if (Input.GetMouseButtonDown(0))  //�Ű�����: 0�� ��Ŭ��, 1�� ��Ŭ��
        {
            Debug.Log("�̻��� �߻�!");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������ ��...");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("���� �̻��� �߻�!!");
        }

        //  GetButton �ޱ� (Edit - {rogram Settings - Input Manager)

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("����!");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("���� ������ ��...");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("���� ����!!");
        }

        // Jump�� SpaceŰ���� �� �� �ִ�. (Input Manager �Ǽ�)
        // Input Manager-Axe-Size�� �ø��� ���� Ű Input�� �� ������ �� �ִ�.

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��.." + Input.GetAxis("Horizontal"));
            //  GetAxis -> GetAxisRaw �� �����ϸ� ��,����,��(-1,0,1)
            //  �� Ȯ���� �� �ִ�. ����ġ ����.
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��.." + Input.GetAxisRaw("Vertical"));
        }

    }

}

/*
public class LifecyclePractice : MonoBehaviour
{

    void Awake()  // �ʱ�ȭ ����
    {
        Debug.Log("�÷��̾� ������ �غ� �Ϸ�");
    }

    void OnEnable()  //���� ������Ʈ Ȱ��ȭ �� ����. ����1ȸ �ƴ�, onoff����
    {
        Debug.Log("�÷��̾� �α��� �Ϸ�");
    }

    void Start()  // �ʱ�ȭ ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate() // ������ - �������� ������Ʈ (������ �����ֱ�� CPU ���� ���)
    {
        Debug.Log("�̵�!");  // �� 50fps
    }

    void Update()  // ������ - ���ӷ��� ������Ʈ
    {
        Debug.Log("���� �糶!");  //  �� 60fps, ��ǻ�� ��Ȳ�� ���� �ٸ�.
    }

    void LateUpdate()  // ��� ������Ʈ�� ���� �� ����. ī�޶� ���� ��ó��
    {
        Debug.Log("����ġ ȹ��.");  // �� 60fps, ��ǻ�� ��Ȳ�� ���� �ٸ�.
    }

    void OnDisable()  //  ���� ������Ʈ ��Ȱ��ȭ�� ����.
    {
        Debug.Log("�÷��̾� �α׾ƿ� �Ϸ�");
    }

    void OnDestroy()  //  ���� ������Ʈ �����ϸ� �����.
    {
        Debug.Log("�÷��̾� ������ ��ü �Ϸ�");
    }

}
*/