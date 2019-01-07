using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollViewTest : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{

    public ScrollRect scroll;
    public RectTransform contentRectTrans;

	void Start ()
    {
        //拿到content容器
        contentRectTrans = scroll.content;

        //UI宽度
        Debug.Log(contentRectTrans.rect.xMax);

        //当前UI的左坐标
        Debug.Log(contentRectTrans.rect.xMin);

        //它是当前transform的X轴方向 就是transform.right，自身方向的右方
        Debug.Log(contentRectTrans.right);

        //当前UI底部相对于顶步的相对长度，负数为向下延伸，正数向上延伸
        Debug.Log(contentRectTrans.rect.y);

        //当前UI的宽高
        Debug.Log(contentRectTrans.sizeDelta);

        //UI高度
        Debug.Log("UI高度:"+contentRectTrans.rect.yMin);

        contentRectTrans.sizeDelta = new Vector2(0,900);

        //比例滑动 垂直方向上0到1的值 1=顶部[右边] 0=底部[左边]
        scroll.verticalNormalizedPosition = 1;

        scroll.onValueChanged.AddListener(PrintValue);
    }

    private void PrintValue(Vector2 v2)
    {
        Debug.Log("传递进来的参数：" + v2);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
