using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMap()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
