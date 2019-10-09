using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
        SceneManager.LoadScene(1);
	}
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
