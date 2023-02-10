/*
 * file: Cell.cs
 * author: D.H.
 * feature: 游戏界面的最基本单位
 */

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    public Vector2Int worldPosition;

    public GameObject maskGO;

    public GameObject cellBorderUp, cellBorderRight;

    [Header("点击灵敏度（点击持续时间在此之内的将被忽略）")]
    public float clickSensitivity;

    private Piece pieceWhereon;

    private Action actionOnClicked;

    private float timeCounter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Init(Vector2Int worldPosition, Action actionOnClicked)
    {
        this.worldPosition = worldPosition;
        this.actionOnClicked = actionOnClicked;
    }

    /// <summary>
    /// 为右边界的格子开启边界模式
    /// </summary>
    public void BorderedModeRight()
    {
        cellBorderRight.SetActive(true);
    }

    /// <summary>
    /// 为上边界的格子开启边界模式
    /// </summary>
    public void BorderedModeUp()
    {
        cellBorderUp.SetActive(true);
    }

    public void SwitchMaskMode(string mode)
    {
        maskGO.GetComponent<Mask>().SwitchMode(mode);
    }


    private void OnMouseDown()
    {
        //actionOnClicked.Invoke();
        timeCounter = Time.time;
    }

    private void OnMouseUp()
    {
        float timeSpent = Time.time - timeCounter;
        if (timeCounter > 0.0f && timeSpent > clickSensitivity && GameManager.instance.inDrag == false)
        {
            //Debug.Log($"{this.worldPosition} cell is clicked!");
            actionOnClicked();
        }
    }
}
