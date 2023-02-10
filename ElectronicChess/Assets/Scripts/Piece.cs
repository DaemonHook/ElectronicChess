/*
 * file: Piece.cs
 * author: D.H.
 * feature: 单位
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    #region 单位属性
    public int ATK;
    private int HP, MP;
    public int HPMax, MPMax;

    public int ATKCount;
    public int ATKConsume;
    #endregion

    #region 内部属性
    public Vector2Int wordPosition { get; private set; }
    
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
