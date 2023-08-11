using UnityEngine;

public class theTarget : MonoBehaviour
{

    public int targetWater = 10;
    public int enteredWater = 0;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enteredWater++;
        if( targetWater <= enteredWater )
        {
            gameManager.GetComponent<gameManager>().gameWon();
        }
    }
}
