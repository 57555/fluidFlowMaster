using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public GameObject startBtnUI;
    public GameObject wonPanel;
    public GameObject restartBtn;
    public GameObject lostPanel;
    public GameObject hintPanel;


    private void Start()
    {
        hintPanel.SetActive(true);
        restartBtn.SetActive(false);
        GameObject.FindGameObjectWithTag("music").GetComponent<musicPlayer>().PlayMusic();
        Time.timeScale = 0.0f;
    }


    public void startBtn()
    {
        startBtnUI.SetActive(false);
        Time.timeScale = 1.0f;
        restartBtn.SetActive(true);
    }

    public void gameWon()
    {
        Time.timeScale = 0.0f;
        wonPanel.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameLost()
    {
        Time.timeScale = 0.0f;
        lostPanel.SetActive(true);
    }

    public void okayBtn()
    {
        hintPanel.SetActive(false);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("levelSelect");
    }

    public void loadNext( string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
