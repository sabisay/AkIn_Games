using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    [SerializeField] GameObject _camera;

    private Vector2 touchStartPos;
    private Vector2 touchEndPos;
    private List<Vector3> positionList = new List<Vector3>();
    private int i = 0;

    void Start()
    {
        positionList.Add(new Vector3(43.5999985f, 3.20000005f, -10f));
        positionList.Add(new Vector3(-41.7999992f, 3.20000005f, -10f));
        positionList.Add(new Vector3(-0.0399999991f, 3.20000005f, -10f));

        _camera.transform.position = positionList[i];
    }

    void Update()
    {
        Vector2 swipeDirection = touchEndPos - touchStartPos;

        if (swipeDirection.x > 0 || Input.GetKeyDown(KeyCode.D))
        {
            i = (i + 1) % positionList.Count; // Increment i and wrap it around
            _camera.transform.position = positionList[i];
        }
        else if (swipeDirection.x < 0 || Input.GetKeyDown(KeyCode.A))
        {
            i = (i - 1 + positionList.Count) % positionList.Count; // Decrement i and wrap it around
            _camera.transform.position = positionList[i];
        }
    }
}
