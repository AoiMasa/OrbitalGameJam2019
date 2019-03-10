using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetManager : MonoBehaviour {

    private PlayerManager playerManager;
    
    // Use this for initialization
	void Start () {
        playerManager = this.gameObject.GetComponentInParent<PlayerManager>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerManager.isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerManager.isGrounded = false;
        }
    }

    //private void OnColliderEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        playerManager.isGrounded = true;
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        playerManager.isGrounded = false;
    //    }
    //}
}
