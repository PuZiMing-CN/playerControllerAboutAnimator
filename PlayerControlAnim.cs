using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlAnim : MonoBehaviour
{
    //��ȡAnimator���
    private Animator animator;
   
    void Start()
    {
        //�õ�Animator���
        animator = GetComponent<Animator>();    
    }


    void Update()
    {
        //����Ϊ������ƶ��ķ���
        //��ȡˮƽ��
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡ��ֱ��
        float vertical = Input.GetAxis("Vertical");

        //����
        Vector3 dir=new Vector3(horizontal, 0, vertical);
        //��������:��תʹ������Ԫ��������������ǿ���ĳ������
        //transform.rotation = Quaternion.LookRotation(dir);

        //����Ϊ����ҿ����ƶ�ʱAnimation�����ķ���
        //���ȣ����봴��һ�����ڵ�Player���ϵ�Animator���������
        //Ҫ���������·���ܲ���ת������Ҫʹ�õ�bool���͵Ĳ���
        //����һ��bool�������ƽ���"isRun"��Ȼ�󴴽���������

        if (dir != Vector3.zero)
        {
            //��������
            transform.rotation = Quaternion.LookRotation(dir);//����������ƶ�����
            //�����ܲ��Ķ���
            //GetComponent<Animator>().SetBool("isRun", true);//����ǲ���Ҫ��ȡ����Ĵ�����
            animator.SetBool ("IsRun", true);
            //�ƶ����
            transform.Translate(Vector3.forward*2*Time .deltaTime);
        }
        else
        {
            //����վ���Ķ���
            //GetComponent<Animator>().SetBool("isRun", false);//����ǲ���Ҫ��ȡ����Ĵ�����
            animator.SetBool ("IsRun", false);
        }
    }
}
