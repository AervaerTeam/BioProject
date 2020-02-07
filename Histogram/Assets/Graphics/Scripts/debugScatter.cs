using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugScatter : MonoBehaviour
{
    public GameObject sphere;
    float[] x = { 1, 1, 2, 3, 1, 2, 2, 3, 1, 4, 4, 5, 5, 6, 8, 6, 10, 0 };
    float[] y = { 10, 10, 20, 30, 10, 20, 20, 30, 10, 40, 40, 50, 50, 60, 80, 60, 10, 0 };
    int[] type = { 1, 1, 3, 3, 3, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
    int typeCount = 3;
    public GameObject father;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(x.Length);
        DataAnalisys.Scatter(x, y, type, sphere, father);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
