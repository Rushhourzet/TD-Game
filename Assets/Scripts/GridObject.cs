using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridObject : MonoBehaviour
{
    public Grid grid;
    private int y;
    private int x;

    public int X { get => x; private set => x = value; }
    public int Y { get => y; private set => y = value; }

    public void PlaceObjectOnGrid(int x, int y) {
        this.X = x;
        this.Y = y;
        grid.PlaceGameObjectOnGrid(gameObject, x, y, grid.AddGameObjectToGridRegister);
    }

    public int[] GetPositions() {
        return new int[]{X,Y};
    }
}
