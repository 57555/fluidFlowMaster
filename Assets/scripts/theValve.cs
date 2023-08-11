using UnityEngine;
using UnityEngine.EventSystems;

public class theValve : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    public float speed = 5f;
    public float maxMovement = 1f;


    private bool canMove = false;
    private float maxX;
    private float minX;

    private void Start()
    {
        maxX = transform.localPosition.x + maxMovement;
        minX = transform.localPosition.x - maxMovement;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        canMove = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        canMove = false;
    }


    private void Update()
    {
        if( canMove )
        {
            if (Input.GetAxis("Mouse X") < 0 && transform.localPosition.x > minX)
            {
                transform.localPosition = new Vector3(transform.localPosition.x - Time.fixedDeltaTime * speed, transform.localPosition.y, transform.localPosition.z);
            }
            if (Input.GetAxis("Mouse X") > 0 && transform.localPosition.x < maxX)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + Time.fixedDeltaTime * speed, transform.localPosition.y, transform.localPosition.z);
            }
        }
    }

}
