using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    private static float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 2)
        {
            time += Time.deltaTime;

            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Player"))
            {
                if (obj.transform.localPosition.y < 0.2f)
                {
                    Destroy(obj);
                    Debug.Log("Обьект уничтожен, тк высота < 0.2f");
                }
            }
        }
    }
}
