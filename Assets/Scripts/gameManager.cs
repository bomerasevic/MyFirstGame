using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay=2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    
    

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restart", delay);
        }


    }
     void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
