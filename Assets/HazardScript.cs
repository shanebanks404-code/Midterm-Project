using UnityEngine;

public class HazardScript : MonoBehaviour







{
    public Rigidbody2D myRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float bottom = -2.2f;
    float top = 2.2f;

    public float speed = 2f;
    


    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myRB.linearVelocity = Vector3.up * speed;

    }

    // Update is called once per frame
    void Update()
    {
        //this is the script - .gameObject is the GameObject this script is attached to - .transform is the transform component of the gameobject this is script is attached to
        //this.gameObject.transform
    }

    void FixedUpdate ()
    {
        if(this.gameObject.transform.position.y > top)
        {
            //we have hit the top limit
            //what speed is the hazard currently going? The speed the hazard is going at is 5f.
            //what speed should the hazard change to after hitting the top? After hitting the top the speed should be consist to the speed it took to get up in the first place, so it should be -5f.
            //what is the average frame by frame speed of the hazard? The averrage frame by frame speed is 5.
            //am I moving the transform? or giving a rigidbody velocity? I will give it a rigidbody Velocity.
            myRB.linearVelocity = new Vector2(myRB.linearVelocity.x, -2f); 
                
                
        }

        //check the lower bound and flip the speed
        if(transform.position.y < bottom)
        {
            myRB.linearVelocity = new Vector2(myRB.linearVelocity.x, 2f);

        }
    
    
    
   
    
    
    
    
    
    
    
    }















}

