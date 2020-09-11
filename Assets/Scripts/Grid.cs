using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Grid : MonoBehaviour
{
    private GameObject[,] gridRegister;
    private const float CENTER_OFFSET = 0.5f;
    public FieldData fieldData;

    private Func<GameObject, int, int, bool> addGameObjectToGridRegisterFunc => AddGameObjectToGridRegister;
    private bool initiated = false;

    void InitGridRegister() {
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
    /// <param name="addGameObjectToGridRegisterFunc"></param> The function to add the gameObject to the GridRegister
    public void PlaceGameObjectOnGrid(GameObject go, int x, int y, Func<GameObject, int, int, bool> addGameObjectToGridRegisterFunc) {
        if (!initiated) {
            InitGridRegister();
            initiated = true;
        }

        Vector3 position = new Vector3(x + CENTER_OFFSET, fieldData.thickness, y + CENTER_OFFSET);
        if (addGameObjectToGridRegisterFunc(go, x, y)) 
            Instantiate(go, position, Quaternion.identity);
    }

    /// <summary>
    /// Moves a GameObject on the Grid and GridRegister
    /// </summary>
    public void MoveGameObjectOnGrid(GameObject go, int fromX, int fromY, int toX, int toY, Func<GameObject, int, int, bool> addGameObjectToGridRegisterFunc) {
        if (!initiated) {
            InitGridRegister();
            initiated = true;
        }

        Vector3 position = new Vector3(toX + CENTER_OFFSET, fieldData.thickness, toY + CENTER_OFFSET);

        if (addGameObjectToGridRegisterFunc(go, toX, toY))
            Instantiate(go, position, Quaternion.identity);
    }

    /// <summary>
    /// Will add the gameObject to the Field register so it can be checked for viable placement
    /// </summary>
    /// <param name="go"></param> The GameObject
    /// <param name="x"></param> The position on the x axis
    /// <param name="y"></param> The position on the y axis
    /// <returns> true if the object can be placed succesfully without being occupied/blocked </returns>
    public bool AddGameObjectToGridRegister(GameObject go, int x, int y) {
        if (!initiated) {
            InitGridRegister();
            initiated = true;
        }

        if (CheckIfFieldEmpty(x, y)) {
            gridRegister[x, y] = go;
            return true;
        }
        print("Couldnt place gameObject, because its not empty!");
        return false;
    }

    /// <summary>
    /// Will Move the GameObject on the GridRegister
    /// </summary>
    /// <returns> true if the object can be placed succesfully without being occupied/blocked </returns>
    public bool MoveGameObjectInGridRegister(GameObject go, int fromX, int fromY, int toX, int toY) {
        if (!initiated) {
            InitGridRegister();
            initiated = true;
        }


        if (CheckIfFieldEmpty(toX, toY)) {
            gridRegister[fromX, fromY] = null;
            gridRegister[toX, toY] = go;
            return true;
        }
        print("Couldnt place gameObject, because its not empty!");
        return false;
    }


    public bool CheckIfFieldEmpty(int x, int y) {
        if(gridRegister == null) {
            print("The GridRegister is not yet initiated!");
            return false;
        }
        if(gridRegister[x,y] == null)
            return true;
        else
            return false;
    }

}
