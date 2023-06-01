using UnityEngine.SceneManagement;
using UnityEngine;

public class nolickPolniy : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }    
}

