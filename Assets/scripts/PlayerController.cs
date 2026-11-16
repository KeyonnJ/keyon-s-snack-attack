using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //make a variable to use throughout your project
    public float horizontalInput;
    public float forwardInput;
    public float Speed = 10.0f; 
    //identify your player throughout different scripts
    public GameObject player;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * Time.deltaTime * Speed * horizontalInput);

       
        transform.Translate(Vector3.forward * Time.deltaTime * -Speed * forwardInput);
        
    }

     void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("popcorn"))
        {
            Destroy(other.gameObject);
            score += 1;
            
        }
        else if(other.gameObject.CompareTag("burntP"))
        {
            Destroy(other.gameObject);
            score -= 2;
             
        }
        else if(other.gameObject.CompareTag("butteredP"))
        {
            Destroy(other.gameObject);
            score += 3;
             
        }
        else if(other.gameObject.CompareTag("moltenP"))
        {
            Destroy(other.gameObject);
            score -= 5;
             
        }
         Debug.Log("your now have " + score + " popcorn points!");
    }
}
