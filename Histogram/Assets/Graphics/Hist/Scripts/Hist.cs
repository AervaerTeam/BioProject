using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Hist
{

    public static float[] data;
    public static GameObject cube;
    public static Transform father;
    public static GradientsTheme.Gradient gradient;
    public static byte alpha;
    public static int bins;


    public static void drawHist() => DataAnalisys.hist(data, bins, cube, father, gradient, alpha);

}
