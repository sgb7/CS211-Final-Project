using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
//using System.Security.Policy;
using UnityEngine;

public class Checkers : MonoBehaviour
{
    public GameObject controller;
    //public GameObject movePlate;

    private int xPos = -1;
    private int yPos = -1;

    private string player;

    public Sprite redChecker, redKingChecker;
    public Sprite whiteChecker, whiteKingChecker;

    public void SetCoords()
    {
        float x = xPos;
        float y = yPos;
        x = x * 1.1f;
        y = y * 1.1f;

        x += -3.8f;
        y += -3.8f;

        this.transform.position = new Vector3(x, y, -1.0f);

        /*this.transform.position = new Vector3(Mathf.Round(xPos),
                                     Mathf.Round(yPos),
                                     -1.0f);*/
    }

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();

        switch(this.name)
        {
            case "redChecker":
                this.GetComponent<SpriteRenderer>().sprite = redChecker;
                break;
            case "redKingChecker":
                this.GetComponent<SpriteRenderer>().sprite = redKingChecker;
                break;
            case "whiteChecker":
                this.GetComponent<SpriteRenderer>().sprite = whiteChecker;
                break;
            case "whiteKingChecker":
                this.GetComponent<SpriteRenderer>().sprite = whiteKingChecker;
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "redChecker" && collision.gameObject.name == "whiteChecker")
        {
            Destroy(collision.gameObject);
        }
        //I can't seem to make it so the white checkers will destroy the red checkers when selected. When I try both checkers just end up destroyed.
    }

    public int getXPos()
    {
        return xPos;
    }

    public int getYPos()
    {
        return yPos;
    }

    public void setXPos(int x)
    {
        xPos = x;
    }

    public void setYPos(int y)
    {
        yPos = y;
    }
}
