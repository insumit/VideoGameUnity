using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject gameCamera, targetObject;

    public bool enableTranslation = false;

    void Start()
    {
    }

    void Update()
    {
        if (enableTranslation)
        {
            TranslateCamera();
        }
    }

    private void OnMouseDown()
    {
        enableTranslation = true;
    }

    void TranslateCamera()
    {
        gameCamera.transform.Translate((targetObject.transform.position - gameCamera.transform.position).normalized * Time.deltaTime * 3f, Space.World);
        gameCamera.transform.rotation = Quaternion.Slerp(gameCamera.transform.rotation, targetObject.transform.rotation, Time.deltaTime * 3f);
    }
}
