﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private GameObject[,] gridRegister;
    private const float CENTER_OFFSET = 0.5f;
    public FieldData fieldData;
    void InitGridRegister(CubeMeshGenerator meshGeneratorForDimensions) {
        int x = fieldData.height;
        int y = fieldData.width;
        gridRegister = new GameObject[x, y];
    }

    /// <summary>
    /// Will automatically also add the Gameobject to the Gridregister 
    /// </summary>
    /// <param name="go"></param> The GameObject
    /// <param name="x"></param> The position on the x axis
    /// <param name="y"></param> The position on the y axis
    public void PlaceGameObjectOnGrid(GameObject go, int x, int y) {
        Vector3 position = new Vector3(x + CENTER_OFFSET, fieldData.thickness, y + CENTER_OFFSET);
        if (AddGameObjectToGridRegister(go, x, y)) 
            Instantiate(go, position, Quaternion.identity);
    }

    /// <summary>
    /// Will add the gameObject to the Field register so it can be checked for viable placement
    /// </summary>
    /// <param name="go"></param> The GameObject
    /// <param name="x"></param> The position on the x axis
    /// <param name="y"></param> The position on the y axis
    /// <returns></returns>
    public bool AddGameObjectToGridRegister(GameObject go, int x, int y) {
        if (CheckIfFieldEmpty(x, y)) {
            gridRegister[x, y] = go;
            return true;
        }
        else
            print("Couldnt place gameObject, because its not empty!");
        return false;
    }

    public bool CheckIfFieldEmpty(int x, int y) {
        if(gridRegister[x,y] == null)
            return true;
        else
            return false;
    }

}
