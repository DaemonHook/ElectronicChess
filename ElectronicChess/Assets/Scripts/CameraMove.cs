/*
 * file: CameraMove.cs
 * author: D.H.
 * feature: 移动镜头
 */

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class CameraMove : MonoBehaviour
{
    private Camera thisCamera;

    private Vector2 originPos;
    private Vector2 mouseDownPos;
    private Vector2 difference;

    private Vector2 lastMousePos;

    private bool inDrag = false;

    private Vector2 mapSize;

    [Header("镜头移动边界的容差")]
    public float tolerance;

    [Header("移动持续时间")]
    public float duration;

    private void Awake()
    {
        thisCamera = GetComponent<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(DragMoveCoroutine());
        }
    }

    Vector3 GetMousePositionInWorld()
    {
        Vector3 screenPosition = Input.mousePosition;
        return thisCamera.ScreenToWorldPoint(screenPosition);
    }

    private IEnumerator DragMoveCoroutine()
    {
        Vector3 initialMousePosition = GetMousePositionInWorld();

        while (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = GetMousePositionInWorld();
            Vector3 travel = currentMousePosition - initialMousePosition;

            travel.z = 0;
            transform.DOMove(transform.position-travel, duration);
            yield return null;
        }
    }

    public void Init(Vector2 mapSize, Vector2 originPos)
    {
        this.mapSize = mapSize;

    }


}
