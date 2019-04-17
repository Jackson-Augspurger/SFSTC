using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item; //itemBeingDragged

    Vector3 startPosition;
    Transform startParent;
    private Vector3 newPos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        transform.SetParent(transform.root);


    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToWorldPointInRectangle(this.GetComponent<RectTransform>(), eventData.position, eventData.enterEventCamera, out newPos);
        transform.position = newPos;
    }
    public void OnEndDrag(PointerEventData eventData)
    {

        item = null;

        if (transform.parent == startParent || transform.parent == transform.root)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
            
        }

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
