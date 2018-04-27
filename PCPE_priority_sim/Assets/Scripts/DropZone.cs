using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped on to " + this.gameObject.name);

        eventData.pointerDrag.GetComponent<Draggable>().parentToReturnTo = this.transform;
    }
}
