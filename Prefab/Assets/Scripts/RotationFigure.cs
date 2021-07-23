using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]

public class RotationFigure : MonoBehaviour
{
    [SerializeField]private GameObject gameObject;
    [Tooltip("X-axis rotation")] [Range(-10, 10)] public float rot_x;
    [Tooltip("Y-axis rotation")] [Range(-10, 10)] public float rot_y;
    [Tooltip("Z-axis rotation")] [Range(-10, 10)] public float rot_z;

    [Tooltip("Moving along the x-axis")][Range(-10, 10)] public float x;
    [Tooltip("Moving along the y-axis")] [Range(-10, 10)] public float y;
    [Tooltip("Moving along the z-axis")] [Range(-10, 10)] public float z;

    [Tooltip("Rotation speed")][Range(0,10)][SerializeField] private int speed;
    [SerializeField] private bool isPlayEditor;
    private List<GameObject> clons;
    



    void Update()
    {
        if (isPlayEditor)
        {
            transform.rotation *= Quaternion.Euler(rot_x * Time.deltaTime * speed, rot_y * Time.deltaTime * speed, rot_z * Time.deltaTime * speed);
        }
        transform.position = new Vector3(x, y, z);
    }

    public void Copy()
    {
       GameObject clone =  Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
       //clons.Add(clone); 
    }

    public void Destroy()
    {
        GameObject.DestroyImmediate(gameObject);
    }

    public void DestroyAll(int count)
    {
        for (int i = count; i < clons.Count; i++)
        {
            DestroyImmediate(clons[i]);
            i--;
        }
       
    }
}
