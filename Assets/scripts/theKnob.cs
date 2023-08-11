using UnityEngine;
using UnityEngine.EventSystems;

public class theKnob : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.Rotate(0f, 0f, -90f);
    }
}
