using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject piece;

    private GameObject[,] positions = new GameObject[8, 8];
    private GameObject[] player = new GameObject[12];
    private GameObject[] enemy = new GameObject[12];

    private string currentPlayer = "red";

    private bool gameOver = false;

    void Start()
    {
        player = new GameObject[] { Create("whiteChecker", 0, 7), Create("whiteChecker", 2, 7), Create("whiteChecker", 4, 7), Create("whiteChecker", 6, 7), Create("whiteChecker", 1, 6),
                                   Create("whiteChecker", 3, 6), Create("whiteChecker", 5, 6), Create("whiteChecker", 7, 6), Create("whiteChecker", 0, 5), Create("whiteChecker", 2, 5),
                                   Create("whiteChecker", 4, 5), Create("whiteChecker", 6, 5) };

        enemy = new GameObject[] { Create("redChecker", 0, 0) };
    }
}