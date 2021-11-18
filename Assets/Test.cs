using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

       
       void HelloName(string name)
       {

                Debug.Log ("Hello, " + name);

       }
       

       void Start()
       {

             HelloName ("Unity");

       }
    


    // Update is called once per frame
    void Update()
    {
        
    }
 }
