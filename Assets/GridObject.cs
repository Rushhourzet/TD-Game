using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridObject : MonoBehaviour
{
    public Grid grid;

    public void PlaceObjectOnGrid(int x, int y) {
        grid.PlaceGameObjectOnGrid(gameObject, x, y);
    }
}
