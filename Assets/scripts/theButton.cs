using UnityEngine;
using UnityEngine.EventSystems;

public class theButton : MonoBehaviour, IPointerClickHandler
{

    public GameObject button;


    public void OnPointerClick(PointerEventData eventData)
    {
        button.SetActive(!button.activeSelf);
    }



}
