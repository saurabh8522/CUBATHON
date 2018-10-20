using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;
    public float restartdelay=1f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if(GameHasEnded==false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restart", restartdelay);
        }
        
    }
    void restart()
    {
        SceneManager.LoadScene("level01");
    }
}
