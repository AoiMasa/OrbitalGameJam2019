using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    [SerializeField]
    private string nextLevel = "MainMenu";

    AudioSource audioSource;
    public AudioClip otherClip;

    private bool hasPlayedSound;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        hasPlayedSound = false;
        audioSource = this.GetComponent<AudioSource>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayedSound)
        {
            if (!audioSource.isPlaying)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!hasPlayedSound)
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = otherClip;
                    audioSource.time = 10;
                    audioSource.Play();
                    hasPlayedSound = true;
                    spriteRenderer.enabled = false;
                   // collision.gameObject.GetComponentInParent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                }
            }
           
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            


        }
    }
}
