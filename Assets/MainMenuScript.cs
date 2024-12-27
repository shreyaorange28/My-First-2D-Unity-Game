using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
        //SceneController.instance.LoadScene(1);
        //SceneController.instance.NextLevel();
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
