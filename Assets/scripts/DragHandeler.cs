using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public static GameObject itemBeingDragged;
    Vector2 startPos;
    Transform startparent;

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        if (transform.parent != startparent)
        {
            transform.position = startPos;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPos = transform.position;
        startparent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}
