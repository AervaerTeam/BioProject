using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAnalisys : MonoBehaviour
{
    

    public static float[] SetTop3Value(float[] data)
    {
        /*
         * 
         * Эта функция возвращает массив из шести элементов, где четные 
         * 0 - Самый большой элемент
         * 2 - Второй элемент по велечине
         * 3 - Третий элемент по величине
         * , а нечетные
         * 1 - Сколько раз встретился самый большой элемент
         * 3 - Сколько раз встретился второй по величине
         * 5 - Сколько раз встретился третий по величине элемент.
         */
        float el1 = 0;
        float el1Count = 0;
        float el2 = 0;
        float el2Count = 0;
        float el3 = 0;
        float el3Count = 0;
        foreach (float el in data)
        {
            //Debug.Log(el);
            if (el > el1)
            {
                el1 = el;
                el1Count = 0;
                //Debug.Log(el1);
                foreach (float k in data)
                {
                    if (k == el1)
                    {
                        el1Count++;
                    }
                }
            }
            else if (el > el2)
            {
                el2 = el;
                el2Count = 0;
                foreach (float k in data)
                {
                    if (k == el2)
                    {
                        el2Count++;
                    }
                }
            }
            else if (el > el3)
            {
                el3 = el;
                el3Count = 0;
                foreach (float k in data)
                {
                    if (k == el3)
                    {
                        el3Count++;
                    }
                }
            }
            else
            {
                continue;
            }
        }

        float[] res = new float[] { el1, el1Count, el2, el2Count, el3, el3Count };
        return res;
        }
    public static float[,] SetTop3Count(float[] data)
    {
        /*
         * Функция принимает массив значений и находит 3 наиболее встречающихся
         * Вовращает двумерный массив, где в 0 
         * 0 - количество повторений наиболее часто встречающегося элемента
         * 1 - количество повторений второго по частоте элемента
         * 2 - количество повторений третьего по частоте элемента
         * В 1:
         * 0 - первый элемент
         * 1 - второй элемент
         * 3 - третий элемент
         */

        float firstCount = -1;
        float el1 = -1;

        float secondCount = -1;
        float el2 = -1;

        float thirdCount = -1;
        float el3 = -1;

        // Перебор элементов
        foreach (float el in data)
        {
            // Является ли элемент новым?
            if (el != el1 && el != el2 && el != el3)
            {
                // Сколько раз встречается этот элемент
                float valueCount = count(data, el);


                if (valueCount > firstCount)
                {
                    firstCount = valueCount;
                    el1 = el;
                }
                else if (valueCount > secondCount)
                {
                    secondCount = valueCount;
                    el2 = el;
                }
                else if (valueCount > thirdCount)
                {
                    thirdCount = valueCount;
                    el3 = el;
                }
                else
                    continue;
            }
        }

        float[,] res = new float[,] { {firstCount, secondCount, thirdCount}, { el1, el2, el3 } };
        return res;
    }

    public static float count(float[] data, float element)
    {
        // Считает сколько раз элемент встретился в массиве

        int c = 0;
        foreach (float el in data)
        {
            if (el == element)
            {
                c++;
            }
        }
        return c;
    }
    public static float count(string[] data, string element)
    {
        // Считает сколько раз элемент встретился в массиве
        element = element.ToUpper();
        int c = 0;
        foreach (string el in data)
        {            
            if (el.ToUpper() == element)
            {
                c++;
            }
        }
        return c;
    }

    public static float[] MinMaxFromArray(float[] data)
    {
        // Возвращает минимальное и максимальное значение массива.

        float min = data[0];
        float max = data[0];

        foreach (float el in data)
        {
            if (el > max)
            {
                max = el;
            }
            else if (el < min)
            {
                min = el;
            }
        }
        max++;
        float[] res = new float[] { min, max };
        return res;
    }

    public static float countInInterval(float[] data, float min, float max)
    {
        float k = 0;
        foreach (float el in data)
        {
            if(el > min && el <= max)
            {
                k++;
            }
        }
        return k;
    }

    private static float[,] MathHist(float[] data, int bins)
    {
        // Разбивает массив на bins интервалов по значению.
        // Возвращает двумерный массив, где в каждом значении 0 - это "от"; а 1 - это "до"

        float max = MinMaxFromArray(data)[1];
        float min = MinMaxFromArray(data)[0];

        float interval = max - min;
        float step = interval / bins;

        float[,] intervals = new float[bins, 2];

        float thisValue = 0;
        for (int i = 0; i < bins; i++)
        {
            intervals[i, 0] = thisValue;
            thisValue += step;
            intervals[i, 1] = thisValue;
        }
        intervals[bins - 1, 1] = max;
        return intervals;
    }
    public static void hist(float[] data, int bins, GameObject cube, Transform father, GameObject intervalTxt, GradientsTheme.Gradient gradient, byte alpha)
    {
        // Рисует гистограму 3д с привязкой к родителю.
        Color32[] colors = GradientsTheme.SetGradient(gradient, bins, alpha);
        float[,] intervals = MathHist(data, bins);
        float width = 10 / bins;
        float k = 5.625f; // Высота максимального значения
        float kf = k / SetTop3Count(data)[0, 0];
        
        for (int i = 0; i < bins; i++)
        {

            if (i == 0)
            {
                GameObject obj = Instantiate(cube);
                obj.transform.SetParent(father);
                obj.GetComponent<MeshRenderer>().material.color = colors[i];
                GameObject txtObj = Instantiate(intervalTxt);
                obj.transform.transform.localScale = new Vector3((10.0f / bins), countInInterval(data, intervals[i, 0] - 1f, intervals[i, 1]) * kf, 10.0f / bins);
                obj.transform.position = new Vector3(-5.0f + (obj.transform.localScale.x / 2.0f) + i * (obj.transform.localScale.x), obj.transform.localScale.y / 2.0f, obj.transform.position.z);
                string text = "" + intervals[i, 0];
                txtObj.GetComponent<TextMesh>().text = text;
                txtObj.transform.position = obj.transform.position;
            }
            else if (i == bins - 1)
            {
                GameObject obj = Instantiate(cube);
                obj.transform.SetParent(father);
                obj.GetComponent<MeshRenderer>().material.color = colors[i];
                GameObject txtObj = Instantiate(intervalTxt);
                obj.transform.transform.localScale = new Vector3((10.0f / bins), countInInterval(data, intervals[i, 0], intervals[i, 1] + 1) * kf, 10.0f / bins);
                obj.transform.position = new Vector3(-5.0f + (obj.transform.localScale.x / 2.0f) + i * (obj.transform.localScale.x) + (father.transform.position.x - 0), obj.transform.localScale.y / 2.0f, obj.transform.position.z);
                string text = "" + (intervals[i, 1] - 1);
                txtObj.GetComponent<TextMesh>().text = text;
                txtObj.transform.position = obj.transform.position;
            }
            else
            {
                GameObject obj = Instantiate(cube);
                obj.transform.SetParent(father);
                obj.GetComponent<MeshRenderer>().material.color = colors[i];
                //GameObject txtObj = Instantiate(intervalTxt);
                obj.transform.transform.localScale = new Vector3((10.0f / bins), countInInterval(data, intervals[i, 0], intervals[i, 1]) * kf, 10.0f / bins);
                obj.transform.position = new Vector3(-5.0f + (obj.transform.localScale.x / 2.0f) + i * (obj.transform.localScale.x), obj.transform.localScale.y / 2.0f, obj.transform.position.z);
                string text = intervals[i, 0] + "-" + intervals[i, 1];
                //txtObj.GetComponent<TextMesh>().text = text;
                //txtObj.transform.position = obj.transform.position;
            }
        }
    }

    public static void Scatter(float[] x, float[] y, GameObject dot, GameObject father)
    {
        // На вход принимает два равных массива
        
        
        float xLen = MinMaxFromArray(x)[1] - MinMaxFromArray(x)[0];
        float yLen = MinMaxFromArray(y)[1] - MinMaxFromArray(y)[0];
        float kfX = 10 / xLen;
        float kfY = 10 / yLen;
        for (int i = 0; i < x.Length; i++)
        {
            Debug.Log(i);
            GameObject obj = Instantiate(dot);
            obj.transform.parent = father.transform;
            obj.transform.localPosition = new Vector3(x[i] * kfX - 5, obj.transform.position.y,y[i] * kfY - 5);
        }
    }
    public static void Scatter(float[] x, float[] y, int[] type, GameObject dot, GameObject father)
    {
        // На вход принимает два равных массива

        float xLen = MinMaxFromArray(x)[1] - MinMaxFromArray(x)[0];
        float yLen = MinMaxFromArray(y)[1] - MinMaxFromArray(y)[0];
        float kfX = 10 / xLen;
        float kfY = 10 / yLen;
        Color32[] colors = GradientsTheme.SetMyGradient(new Color32(0,0,0,255), new Color32(255,255,255,255), type.Length, 255);
        for (int i = 0; i < x.Length; i++)
        {
            GameObject obj = Instantiate(dot);
            obj.transform.parent = father.transform;
            obj.transform.localPosition = new Vector3(x[i] * kfX - 5, obj.transform.position.y, y[i] * kfY - 5);

            obj.GetComponent<MeshRenderer>().material.color = colors[type[i]];
        }
    }
}


