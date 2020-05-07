using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject piece;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(piece, new Vector3(0, 0, -1), Quaternion.identity);
    }
}