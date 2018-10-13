using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinderScript : MonoBehaviour
{

    GameObject Grid; 

    GridManager script; 

    void Start()
    {
        Grid = GameObject.Find("Grid");
        script = GetComponent<GridManager>(); 
    }

   
    public void OnClick()
    {
        script.hindersamon();
    }
}