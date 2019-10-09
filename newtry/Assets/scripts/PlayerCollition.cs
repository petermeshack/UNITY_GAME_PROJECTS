using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollition : MonoBehaviour {

    public PlayerMovement movement;
    public float restsrtDelay = 2f;
    
    void OnCollisionEnter(Collision colliderinfo)
    {
        if (colliderinfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Invoke("Restart", restsrtDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
