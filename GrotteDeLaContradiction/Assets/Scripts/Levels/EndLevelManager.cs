using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelManager : MonoBehaviour {

    [SerializeField]
    private string nextLevel = "MainMenu";


    private bool hasToRestart;

    // Use this for initialization
    void Start () {
        hasToRestart = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPlayerFollowedRules(GameEventMessage message)
    {
        hasToRestart = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (hasToRestart)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            else
                SceneManager.LoadScene(nextLevel);
        }
    }
}
