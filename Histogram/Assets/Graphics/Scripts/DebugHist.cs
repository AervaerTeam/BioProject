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
    public float[] data = {1,1,2,2,2,3,3 };
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
