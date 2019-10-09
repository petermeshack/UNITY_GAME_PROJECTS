using UnityEngine;
using UnityEngine.SceneManagement;
public class LevalComplete : MonoBehaviour {

    public void LoadNextLeval()
    {
        SceneManager.LoadScene(2);
    }
}
