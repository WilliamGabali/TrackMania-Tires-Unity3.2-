using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceen : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadSceen(string sceen)
    {
        SceneManager.LoadScene(sceen);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
