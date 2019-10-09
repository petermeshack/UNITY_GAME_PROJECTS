using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody PlayerRigid;
    public float fowardforce = 500f;
    public float sidemovement = 500f;
    public float restsrtDelay = 2f;
    public float androidsidemovement = 100f;
    


	
	// FixedUpdate is called once per frame
    //it is also used to manupulate physics
    void FixedUpdate()
    {
        //add a fowardforce
        PlayerRigid.AddForce(0, 0, fowardforce * Time.deltaTime); //add force of 200 in the z axis in current time

        //movement om the left x
        if (Input.GetKey("d"))
        {
            PlayerRigid.AddForce(sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //movement on the right x
        if (Input.GetKey("a"))
        {
            PlayerRigid.AddForce(-sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*/accelerating on the z
        if (Input.GetKey("w"))
        {
            PlayerRigid.AddForce(0, 0, fowardforce * Time.deltaTime);
        }*/
        /*/decelerating on the z
        if (Input.GetKey("s"))
        {
            PlayerRigid.AddForce(0, 0, -fowardforce* 0.05 * Time.deltaTime,ForceMode.VelocityChange);
        }*/



        if (PlayerRigid.position.y < 1f)
        {
            Invoke("Restart", restsrtDelay);
        }
    }

    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AndroidClickLeft()
    {
        PlayerRigid.AddForce(-androidsidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void AndroidClickRight()
    {
        PlayerRigid.AddForce(androidsidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
