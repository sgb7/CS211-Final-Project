using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject piece;

    private GameObject[,] positions = new GameObject[8, 8];
    private GameObject[] player = new GameObject[12];
    private GameObject[] enemy = new GameObject[12];

    private string currentPlayer = "red";

    private bool gameOver = false;

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(piece, new Vector3(0, 0, -1), Quaternion.identity);
        Checkers checkers = obj.GetComponent<Checkers>();
        checkers.name = name;
        checkers.setXPos(x);
        checkers.setYPos(y);
        checkers.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        Checkers checkers = obj.GetComponent<Checkers>();

        positions[checkers.getXPos(), checkers.getYPos()] = obj;
    }

    public void SetPositionEmpty(int x, int y)
    {
        positions[x, y] = null;
    }

    public GameObject GetPosition(int x, int y)
    {
        return positions[x, y];
    }

    public bool isOnBoard(int x, int y)
    {
        if(x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void Start()
    {
        enemy = new GameObject[] { Create("whiteChecker", 1, 7), Create("whiteChecker", 3, 7), Create("whiteChecker", 5, 7), Create("whiteChecker", 7, 7), Create("whiteChecker", 0, 6),
                                   Create("whiteChecker", 2, 6), Create("whiteChecker", 4, 6), Create("whiteChecker", 6, 6), Create("whiteChecker", 1, 5), Create("whiteChecker", 3, 5),
                                   Create("whiteChecker", 5, 5), Create("whiteChecker", 7, 5) };

        player = new GameObject[] { Create("redChecker", 0, 0), Create("redChecker", 2, 0), Create("redChecker", 4, 0), Create("redChecker", 6, 0), Create("redChecker", 1, 1),
                                   Create("redChecker", 3, 1), Create("redChecker", 5, 1), Create("redChecker", 7, 1), Create("redChecker", 0, 2), Create("redChecker", 2, 2),
                                   Create("redChecker", 4, 2), Create("redChecker", 6, 2) };

        for(int i = 0; i < player.Length; i++)
        {
            SetPosition(player[i]);
            SetPosition(enemy[i]);
        }
    }
}