using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour

{
   //for the audio 
    public AudioSource AS;
    AudioSource audioSource;

    //For Lose Audio
    public AudioClip LoseAim;

    public TextMeshPro GoalText;
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public Animator coinAnim;



    




    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        coinAnim = GetComponent<Animator>();
        GoalText.gameObject.SetActive(false);

        AS = GetComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();


    }


    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            AS.Play();
            Debug.Log("audio source playing bool: " + AS.isPlaying);
            coinAnim.Play("winAim");
            Debug.Log("You Win - collided with: " + collision.gameObject.name);
            Debug.Log(AS);

         }
      
        if (collision.gameObject.tag == "Hazard")
        {

             audioSource.PlayOneShot(LoseAim, 0.7F);
            coinAnim.Play("loseAim");
            SceneManager.LoadScene("Game Over");
            Debug.Log(gameObject.name + " collided with something, and that something had the tag hazard: " + collision.gameObject.name);


        }

        
           
    }

    public void WinScene()
    {
        SceneManager.LoadScene("You Win");
    }

    public void LoseScene()
    {
        SceneManager.LoadScene("Game Over");
    }


   



}