using UnityEngine;

public class theFloor : MonoBehaviour
{
    public int lostWater = 38;
    public int currentLost = 0;
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentLost++;
        if (currentLost >= lostWater)
        {
            gameManager.GetComponent<gameManager>().gameLost();
        }
    }
}
