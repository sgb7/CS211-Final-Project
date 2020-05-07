using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    //public GameObject controller;
    public GameObject movePlate;

    private GameManager gameManager;

    //GameObject reference = null;

    //int matrixX;
    //int matrixY;

    public bool attack = false; // Make MovePlate go from green to red when attacking?

    public void moveOptions(GameObject obj)
    {

    }

    public void Start()
    {
        //Instantiate  move plates in right places
        // Need to:
                // Know if plates ahead are null or not
                // If not, if the plates beyond them are
        if(attack)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }


}
