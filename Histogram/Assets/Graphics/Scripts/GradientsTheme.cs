using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientsTheme : MonoBehaviour
{
    public enum Gradient {
        //Clasick
        Portrait, MetalicToad, Lizard, ForeverLost, 
        //Blue group
        DeepSeaSpace, TelegramLike, CocoaaIce, Disco, BackToEarthBiomax, BetweenDayAndNightBioRythms, EndlessRiver,
        //Red group
        RedOcean, 
        //Green group
        SummerDog,
        //ExtraColor Group
        Metapolis, Ali, Superman, Pizelex, ShoreBio, 
        FreshTurboscent, KokoCaramel, VirginAmerica, 
        TurquioiseFlow, PastelOrangeAtTheSun, PurpleBliss, CrazyOrangeI, Friday }

    public GameObject exCube;
    // Start is called before the first frame update
    void Start()
    {
        exCube.transform.GetComponent<Renderer>().material.color = new Color32(61, 114, 180, 1);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static Color32[] SetGradient(Gradient gradient, int bins, byte alpha)
    {
        Color32[] colors = new Color32[bins];

        //Clisick Theme
        if (gradient == Gradient.Portrait)
        {
            Vector3Int start = new Vector3Int(142, 158, 171);
            Vector3Int end = new Vector3Int(238, 242, 243);
            return SetMyGradient(start, end, bins, alpha);
        }        
        else if (gradient == Gradient.MetalicToad)
        {
            Vector3Int start = new Vector3Int(171, 186, 171);
            Vector3Int end = new Vector3Int(255, 255, 255);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Lizard)
        {
            Vector3Int start = new Vector3Int(48, 67, 82);
            Vector3Int end = new Vector3Int(215, 210, 204);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.ForeverLost)
        {
            Vector3Int start = new Vector3Int(93, 65, 87);
            Vector3Int end = new Vector3Int(168, 202, 186);
            return SetMyGradient(start, end, bins, alpha);
        }
        //Blue Theme
        else if (gradient == Gradient.DeepSeaSpace)
        {
            Vector3Int start = new Vector3Int(44, 62, 80);
            Vector3Int end = new Vector3Int(76, 161, 175);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.TelegramLike)
        {
            Vector3Int start = new Vector3Int(28, 146, 210);
            Vector3Int end = new Vector3Int(242, 252, 254);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.CocoaaIce)
        {
            Vector3Int start = new Vector3Int(192, 192, 170);
            Vector3Int end = new Vector3Int(28, 239, 255);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Disco)
        {
            Vector3Int start = new Vector3Int(78, 205, 196);
            Vector3Int end = new Vector3Int(85, 98, 112);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.BackToEarthBiomax)
        {
            Vector3Int start = new Vector3Int(0, 201, 255);
            Vector3Int end = new Vector3Int(146, 254, 157 );
            return SetMyGradient(start, end, bins, alpha);
        }//BIOMax
        else if (gradient == Gradient.BetweenDayAndNightBioRythms)
        {
            Vector3Int start = new Vector3Int(44, 62, 80);
            Vector3Int end = new Vector3Int(52, 152, 219);
            return SetMyGradient(start, end, bins, alpha);
        }//BIORythms
        else if (gradient == Gradient.EndlessRiver)
        {
            Vector3Int start = new Vector3Int(67, 206, 162);
            Vector3Int end = new Vector3Int(24, 90, 157);
            return SetMyGradient(start, end, bins, alpha);
        }//AQUA
        //Red theme
        else if (gradient == Gradient.RedOcean)
        {
            Vector3Int start = new Vector3Int(29, 67, 80);
            Vector3Int end = new Vector3Int(164, 57, 49);
            return SetMyGradient(start, end, bins, alpha);
        }
        //Green Theme
        else if (gradient == Gradient.SummerDog)
        {
            Vector3Int start = new Vector3Int(168, 255, 120);
            Vector3Int end = new Vector3Int(120, 255, 214);
            return SetMyGradient(start, end, bins, alpha);
        }
        //Extra Color Theme
        else if (gradient == Gradient.Metapolis)
        {
            Vector3Int start = new Vector3Int(101, 153, 153);
            Vector3Int end = new Vector3Int(244, 121, 31);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Ali)
        {
            Vector3Int start = new Vector3Int(255, 75, 31);
            Vector3Int end = new Vector3Int(31, 221, 255);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Superman)
        {
            Vector3Int start = new Vector3Int(0, 153, 247);
            Vector3Int end = new Vector3Int(241, 23, 18);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Pizelex)
        {
            Vector3Int start = new Vector3Int(17, 67, 87);
            Vector3Int end = new Vector3Int(242, 148, 146);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.ShoreBio)
        {
            Vector3Int start = new Vector3Int(112, 255, 245);
            Vector3Int end = new Vector3Int(255, 209, 148);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.CrazyOrangeI)
        {
            
        }
        else if (gradient == Gradient.FreshTurboscent)
        {
            Vector3Int start = new Vector3Int(241, 242, 181);
            Vector3Int end = new Vector3Int(19, 80, 88);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.KokoCaramel)
        {
            Vector3Int start = new Vector3Int(209, 145, 60);
            Vector3Int end = new Vector3Int(255, 209, 148);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.VirginAmerica)
        {
            Vector3Int start = new Vector3Int(123, 67, 151);
            Vector3Int end = new Vector3Int(220, 36, 48);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.TurquioiseFlow)
        {
            Vector3Int start = new Vector3Int(19, 106, 138);
            Vector3Int end = new Vector3Int(38 , 120, 113);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.PastelOrangeAtTheSun)
        {
            Vector3Int start = new Vector3Int(255, 179, 71);
            Vector3Int end = new Vector3Int(255, 204, 51);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.PurpleBliss)
        {
            Vector3Int start = new Vector3Int(54, 0, 51);
            Vector3Int end = new Vector3Int(11, 135, 147);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.MetalicToad)
        {
            Vector3Int start = new Vector3Int(171, 186, 171);
            Vector3Int end = new Vector3Int(255, 255, 255);
            return SetMyGradient(start, end, bins, alpha);
        }
        else if (gradient == Gradient.Friday)
        {
            Vector3Int start = new Vector3Int(131, 164, 212);
            Vector3Int end = new Vector3Int(182, 251, 255);
            return SetMyGradient(start, end, bins, alpha);
        }

        return colors;
        
    }
    public static Color32[] SetMyGradient(Vector3Int startColor, Vector3Int endColor, int bins, byte alpha)
    {
        Color32[] colors = new Color32[bins];

        Vector3Int start = startColor;
        Vector3Int end = endColor;
        int stepX = (end.x - start.x) / bins;
        int stepY = (end.y - start.y) / bins;
        int stepZ = (end.z - start.z) / bins;

        Vector3Int step = new Vector3Int(stepX, stepY, stepZ);
        Vector3Int thisVector = start;
        for (int i = 0; i < bins; i++)
        {
            byte x = byte.Parse(thisVector.x.ToString());
            byte y = byte.Parse(thisVector.y.ToString());
            byte z = byte.Parse(thisVector.z.ToString());
            colors[i] = new Color32(x, y, z, alpha);
            thisVector += step;
        }
        return colors;
    }
}
