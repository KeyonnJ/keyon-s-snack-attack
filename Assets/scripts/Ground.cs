using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[] PopcornPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("popcorn"))
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("burntP"))
                {
                    Destroy(other.gameObject);
                }
        if(other.gameObject.CompareTag("butteredP"))
                {
                    Destroy(other.gameObject);
                }
        if(other.gameObject.CompareTag("moltenP"))
                {
                    Destroy(other.gameObject);
                }
    }
}
