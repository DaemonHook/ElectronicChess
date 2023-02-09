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

    [Header("镜头移动边界的容差")]
    public float tolerance;

    [Header("镜头移动的灵敏度")]
    public float sensitivity;

    [Header("移动持续时间")]
    public float duration;

    private Vector2 mapSize;

    private void Awake()
    {
        thisCamera = GetComponent<Camera>();
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
            if (travel.magnitude / transform.GetComponent<Camera>().orthographicSize > sensitivity)
            {
                GameManager.instance.inDrag = true;
                CameraMoveWithTolerance(transform.position - travel);
            }
            yield return null;
        }
        GameManager.instance.inDrag = false;
    }

    public void CameraMoveWithTolerance(Vector3 target)
    {
        if (target.y < -tolerance)
        {
            target.y = -tolerance;
        }
        if (target.x < -tolerance)
        {
            target.x = -tolerance;
        }
        if (target.y > mapSize.y + tolerance)
        {
            target.y = mapSize.y + tolerance;
        }
        if (target.x > mapSize.x + tolerance)
        {
            target.x = mapSize.x + tolerance;
        }
        transform.DOMove(target, duration);
    }

    public void Init(Vector2 mapSize, Vector2 originPos)
    {
        this.mapSize = mapSize;
        transform.position = new Vector3(originPos.x, originPos.y, -10.0f);
    }
}
