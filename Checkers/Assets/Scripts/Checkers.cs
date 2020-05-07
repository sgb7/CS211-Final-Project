using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkers : MonoBehaviour
{
    public GameObject controller;
    // public GameObject movePlate; ???

    private int xPos = -1;
    private int yPos = -1;

    private string player;

    public Sprite redChecker, redKingChecker;
    public Sprite whiteChecker, whiteKingChecker;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();
    }
}
