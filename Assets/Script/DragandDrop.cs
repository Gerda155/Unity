using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransForm;
    public Canvas canv;

    void Start()
    {
        rTransForm = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Izdarīts klikšis uz velkama objekta :>");
    }
    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Uzsākta vilkšana");
    }
    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0 + rTransForm.rect.width / 2, Screen.width - rTransForm.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransForm.rect.height / 2, Screen.height - rTransForm.rect.height / 2);

        rTransForm.position = mousePosition;
        Debug.Log("x = "+mousePosition.x+", y = "+mousePosition.y);
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Objekts atlaists, vikšana pārtraukta!");
    }
}
