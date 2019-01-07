# 《DoTween 学习》

## 1.DoTween静态方法

```cs
    DOTween.To(()=>image.color, toColor => image.color = toColor, new Color(0,0,0,0), 2f);

    DOTween.To(
			()=> 
			image.color, //参数1：要改变的目标
			toColor //参数2：当前差值[每次DoTween经过计算得到的结果]
			=> image.color = toColor, //把差值赋值给目标
			new Color(0,0,0,0), //期望目标值
			2f);//效果的时间
```  


## 2.Tranform方法

```cs
    //必须先正播，才可以进行倒播。不能直接倒播
    Tween tween = transform.DOLocalMoveX(300,0.5f);
    tween.PlayForward();//正播
    tween.PlayBackwards();//倒播
```


## 3.循环动画

```cs
    //3.动画的循环使用
    tween = transform.DOLocalMoveX(300,0.5f);
    tween.SetAutoKill(false);//自动销毁动画[必须]
    tween.Pause();//暂停

    tween.PlayForward();//可以循环播放
    tween.Play();//只播放一次
```


## 4.回调函数

```cs
    tween = transform.DOLocalMoveX(300,0.5f);
    //播放完成回调函数
    tween.OnComplete(Complete);
    
    //播放完成回调函数
	private void Complete(){
		DOTween.To(()=>image.color, toColor => image.color = toColor, new Color(0,0,0,0), 2f);
	}
```

## 5.设置动画的缓动函数以及循环状态跟次数

```cs
    tween = transform.DOLocalMoveX(300,0.5f);
    //缓动曲线
    tween.SetEase(Ease.InOutBounce);
    //循环次数 参数1：-1=无穷次 参数2：循环类型
    tween.SetLoops(-1,LoopType.Yoyo);
```