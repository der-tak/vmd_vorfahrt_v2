using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(currentSceneIndex + 1);
    }

    public void LoadNextScene(int sceneID)
    {
        SceneManager.LoadSceneAsync(sceneID);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(1);
    }

    public void CheckPreloadScene()
    {
        GameObject check = GameObject.Find("__app");
        if (check == null)
        { UnityEngine.SceneManagement.SceneManager.LoadScene(0); }
    }

    public void LoadVehicleScene()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
    }
}
