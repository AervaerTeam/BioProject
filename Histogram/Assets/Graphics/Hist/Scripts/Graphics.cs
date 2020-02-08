using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphics : MonoBehaviour
{
    public static TypesOfGraphics typesOfGraphics;

    public static Transform father;
    public static GameObject cube;
    public static GradientsTheme.Gradient gradient;
    public static float[] data;
    public static int bins;
    public static byte alpha = 200;
    public static float[] x;
    public static float[] y;
    public static float[] type;
    public enum TypesOfGraphics { hist, scatter};
    // Start is called before the first frame update
    public static void saveData(float[] data1, GameObject cube1, Transform father1, GradientsTheme.Gradient gradient1, int bins1)
    {
        father = father1;
        data = data1;
        cube = cube1;
        gradient = gradient1;
        bins = bins1;
    }
    public static void saveData(float[] x, float[] y, int[] type, int bins1)
    {

    }

}
