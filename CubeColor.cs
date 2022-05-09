using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeColor : MonoBehaviour {
  
    public Renderer rend;
    Material entrymat,exitmat;



    void Start()
    {
        entrymat = Resources.Load("Texture", typeof(Material)) as Material;
        exitmat = Resources.Load("Texture2", typeof(Material)) as Material;
        rend = GetComponent<Renderer>();
    }
    
   
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        { 
            rend.GetComponent<Renderer>().material = entrymat;
        }
    }
    void OnMouseEnter()
    {
        rend.GetComponent<Renderer>().material = entrymat;
    }
    void OnMouseExit()
    {
        rend.GetComponent<Renderer>().material = exitmat;
    }
}
