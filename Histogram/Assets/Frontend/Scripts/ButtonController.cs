using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    InputField firstValue;
    InputField secondValue;
    InputField thirdValue;
    Transform father;
    public GradientsTheme.Gradient gradient;
    InputField binsInput;
    public TextEditor text;

    public int iteration = 0;
    
    public Text valuesCount;

    float[] x;
    float[] y;
    int[] type;
    public GameObject sphere;
    public GameObject cube;

    int bins;
    public void AddButton()
    {
        
        float first = float.Parse(firstValue.text.ToString());
        float second = float.Parse(secondValue.text.ToString());
        int third = int.Parse(thirdValue.text.ToString());
        x[iteration] = first;
        y[iteration] = second;
        type[iteration] = third;
        iteration++;
    } 
    public void hist1( GradientsTheme.Gradient gradient1)
    {
        bins = int.Parse(binsInput.text.ToString());
        Graphics.saveData(x, cube, father, gradient1, bins);
    }
    public void hist2(GradientsTheme.Gradient gradient1) {
        bins = int.Parse(binsInput.text.ToString());
        Graphics.saveData(y, cube, father, gradient1, bins);
    }
    public void scatter()
    {
        bins = int.Parse(binsInput.text.ToString());
        Graphics.saveData(x, y, type, bins);
    }
    private void Update()
    {
        text.text = "jgds";
    }
}

