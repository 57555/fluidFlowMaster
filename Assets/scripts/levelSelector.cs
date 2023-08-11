using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelector : MonoBehaviour
{

    private void Start()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<musicPlayer>().PlayMusic();
    }


    public void select( string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
