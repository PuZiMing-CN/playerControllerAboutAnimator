using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlAnim : MonoBehaviour
{
    //获取Animator组件
    private Animator animator;
   
    void Start()
    {
        //拿到Animator组件
        animator = GetComponent<Animator>();    
    }


    void Update()
    {
        //这里为让玩家移动的方法
        //获取水平轴
        float horizontal = Input.GetAxis("Horizontal");
        //获取垂直轴
        float vertical = Input.GetAxis("Vertical");

        //向量
        Vector3 dir=new Vector3(horizontal, 0, vertical);
        //面向向量:旋转使用了四元数，这个方法就是看向某个方向
        //transform.rotation = Quaternion.LookRotation(dir);

        //这里为让玩家控制移动时Animation触发的方法
        //首先，必须创建一个挂在到Player身上的Animator组件！！！
        //要做人物从走路到跑步的转换，需要使用到bool类型的参数
        //创建一个bool参数名称叫做"isRun"，然后创建过渡条件

        if (dir != Vector3.zero)
        {
            //面向向量
            transform.rotation = Quaternion.LookRotation(dir);//让玩家面向移动方向
            //播放跑步的动画
            //GetComponent<Animator>().SetBool("isRun", true);//这个是不需要获取组件的带代码
            animator.SetBool ("IsRun", true);
            //移动玩家
            transform.Translate(Vector3.forward*2*Time .deltaTime);
        }
        else
        {
            //播放站立的动画
            //GetComponent<Animator>().SetBool("isRun", false);//这个是不需要获取组件的带代码
            animator.SetBool ("IsRun", false);
        }
    }
}
