
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public GameObject completeLevelUI;
   public void EndGame()
    {
        
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", 2f); //delay (func name, delay
           
        }
    }
    public void CompleteLevel()
    {

        completeLevelUI.SetActive(true);

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    
   
}
