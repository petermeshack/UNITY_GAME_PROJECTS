using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform ThePlayer;

    public Vector3 offset;
	// Update is called once per frame
	void Update () {
        transform.position = ThePlayer.position + offset;

	}
}
