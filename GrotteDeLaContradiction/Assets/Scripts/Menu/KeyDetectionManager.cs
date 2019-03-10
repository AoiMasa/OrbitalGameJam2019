using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDetectionManager : MonoBehaviour
{
    [SerializeField]
    private string submitScene = null;
    [SerializeField]
    private string cancelScene = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (!string.IsNullOrWhiteSpace(submitScene)) SceneManager.LoadScene(submitScene);
        }
        else if (Input.GetButtonDown("Cancel"))
        {
            if (!string.IsNullOrWhiteSpace(cancelScene)) SceneManager.LoadScene(cancelScene);
        }
        else if (Input.GetButtonDown("Exit"))
        {
            if (Application.platform != RuntimePlatform.WebGLPlayer) Application.Quit();
        }
    }
}
