/*
 * file: Cell.cs
 * author: D.H.
 * feature: 游戏界面的最基本单位
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    public Vector2Int worldPosition;

    public GameObject mask;

    private Piece onThis;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Init(Vector2Int worldPosition)
    {
        this.worldPosition = worldPosition;
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log($"{this.worldPosition} cell is clicked!");
    }
}
