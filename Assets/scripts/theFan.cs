using UnityEngine;
using UnityEngine.EventSystems;

public class theFan : MonoBehaviour, IPointerClickHandler
{
    public Transform fan;
    private bool isActive;
    public void OnPointerClick(PointerEventData eventData)
    {
        isActive = !isActive;
    }
    private void Update()
    {
        if(isActive)
        {
            fan.transform.Rotate(0f, 0f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isActive && collision.tag == "water")
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = -1;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isActive && collision.tag == "water")
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = -1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if ( collision.tag == "water")
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = 3;
        }
    }
}
