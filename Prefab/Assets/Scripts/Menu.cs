using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Menu : MonoBehaviour
{
    public static RotationFigure prefab;

    [MenuItem("Costum Editor/Copy")]
    public static void Copy()
    { 
        var rotationFigure = Selection.activeGameObject.GetComponent<RotationFigure>();
        rotationFigure.Copy();
        

    }
    
   
   [MenuItem("Costum Editor/Destroy")]
   public static void Destroy()
   {
        if (Selection.activeGameObject.GetComponent<RotationFigure>()==null)
        {
            Debug.Log("Error!");
        }
        var rotationFigure = Selection.activeGameObject.GetComponent<RotationFigure>();
        rotationFigure.Destroy();
    }

   [MenuItem("Costum Editor/Item/Destroy all child")]
   public static void DestroyAll()
   {
        prefab.DestroyAll(0);
   }    
}
