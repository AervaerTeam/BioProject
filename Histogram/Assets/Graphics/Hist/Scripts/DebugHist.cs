using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugHist : MonoBehaviour
{
    //Префаб куба со стандартным Scale
    public GameObject cube;

    //Родительский объект (обычно камера для AR)
    public Transform parent;

    public GameObject txt;
    public GradientsTheme.Gradient colorTheme;

    //Данные для построения гистограммы.
    public float[] data = {1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 11, 11, 12, 13, 14, 15, 16};
    public int bins = 3;

    // Start is called before the first frame update
    void Start()
    {
        DataAnalisys.hist(data, bins, cube, parent, txt, colorTheme, alpha: 200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
