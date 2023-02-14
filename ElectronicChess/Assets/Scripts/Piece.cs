/*
 * file: Piece.cs
 * author: D.H.
 * feature: 玩家单位
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    #region 单位属性
    [Header("单位类型")]
    public UnitType type;
    [Header("单位层级")]
    public UnitLayer layer;

    public int ATK;
    public int HP, MP;
    public int HPMax, MPMax;

    public int ATKCount;
    public int ATKConsume;
    #endregion


    #region 内部属性
    public Vector2Int wordPosition { get; private set; }
    private Action actionOnClicked;

    /// <summary>
    /// 队伍编号
    /// </summary>
    private int team;
    private float timeCounter;
    #endregion

    public void Init(int teamId)
    {
        transform.GetComponent<SpriteRenderer>().color = GameManager.instance.teamColors[teamId];
    }

    private void OnMouseDown()
    {
        //actionOnClicked.Invoke();
        timeCounter = Time.time;
    }

    private void OnMouseUp()
    {
        float timeSpent = Time.time - timeCounter;
        if (timeCounter > 0.0f && timeSpent > GameManager.instance.clickSensitivity
            && GameManager.instance.inDrag == false)
        {
            actionOnClicked();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
