using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour

{

    public TextMeshPro GoalText;
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            SceneManager.LoadScene("You Win");
       
         }
      
        if (collision.gameObject.tag =="Hazard")
        {

            SceneManager.LoadScene("Game Over");
        }
        

           
    }
    public void Start()
    {
        GoalText.gameObject.SetActive(false);
    }



   



}