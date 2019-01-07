using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTweenTest : MonoBehaviour 
{

	public Image image;
	private Tween tween;

	private void Start() 
	{
		//1.dotween静态方法
		// DOTween.To(
		// 	()=> 
		// 	image.color, //参数1：要改变的目标
		// 	toColor //参数2：当前差值[每次DoTween经过计算得到的结果]
		// 	=> image.color = toColor, //把差值赋值给目标
		// 	new Color(0,0,0,0), //期望目标值
		// 	2f);//效果的时间

		//2.dotween作用于transform的方法
		// Tween tween = transform.DOLocalMoveX(300,0.5f);
		// tween.PlayForward();//正播
		// tween.PlayBackwards();//倒播

		//3.动画的循环使用
		// tween = transform.DOLocalMoveX(300,0.5f);
		// tween.SetAutoKill(false);//自动销毁动画
		// tween.Pause();//暂停

		//4.动画事件回调
		// tween = transform.DOLocalMoveX(300,0.5f);
		// //播放完成回调函数
		// tween.OnComplete(Complete);

		//5.设置动画的缓动函数以及循环状态跟次数
		tween = transform.DOLocalMoveY(-300,0.8f);
		//缓动曲线
		tween.SetEase(Ease.OutElastic);
		//循环次数 参数1：-1=无穷次 参数2：循环类型
		//tween.SetLoops(-1,LoopType.Yoyo);
		tween.SetAutoKill(false);//自动销毁动画
		tween.Pause();//暂停
	}

	//播放完成回调函数
	private void Complete(){
		DOTween.To(()=>image.color, toColor => image.color = toColor, new Color(0,0,0,0), 2f);
	}

	private void Update() {
		if(Input.GetMouseButtonDown(0))
		{
			tween.PlayForward();
		}
		else if(Input.GetMouseButtonDown(1))
		{
			tween.PlayBackwards();
		}
	}
	
}
