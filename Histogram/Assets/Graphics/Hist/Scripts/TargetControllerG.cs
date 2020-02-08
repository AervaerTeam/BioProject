using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetControllerG : MonoBehaviour
{
    [HideInInspector]
    public bool StartShowMessage = false;
    private bool isShowing = false;
    private Sample.ImageTargetManager imageManager;
    private Sample.FilesManager imageCreator;

    public Text savePhoto;
    // Start is called before the first frame update
    void Start()
    {
        imageManager = GameObject.FindObjectOfType<Sample.ImageTargetManager>();
        imageCreator = GameObject.FindObjectOfType<Sample.FilesManager>();
    }

    // Update is called once per frame
    void Update()
    {
     
        
        if (!isShowing)
            StartCoroutine(ShowMessageAndLoadTarget());
        StartShowMessage = false;
        

        if (isShowing)
        {
            savePhoto.enabled = true;
        }
        else {
            savePhoto.enabled = false;
        }
    }
    IEnumerator ShowMessageAndLoadTarget()
    {
        isShowing = true;
        yield return new WaitForSeconds(2f);
        isShowing = false;
        imageManager.LoadTarget();
    }
    public void TakePhoto()
    {
        imageCreator.StartTakePhoto();
    }
    public void deleteTargets()
    {
        imageCreator.ClearTexture();
        imageManager.ClearAllTarget();
    }
}
