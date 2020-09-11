using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridObject : MonoBehaviour
{
    public Grid grid;
    public bool destroyable = false;
    public float maxHealth;
    private float health;
    private int y;
    private int x;

    private bool initiated = false;

    public int X { get => x; private set => x = value; }
    public int Y { get => y; private set => y = value; }
    public float Health { get => health; set => health = value; }

    public void PlaceObjectOnGrid(int x, int y) {
        if (initiated) return;
        this.X = x;
        this.Y = y;
        grid.PlaceGameObjectOnGrid(gameObject, x, y, grid.AddGameObjectToGridRegister);
    }

    public void MoveObjectOnGrid(int x, int y) {
        if (!initiated) {
            PlaceObjectOnGrid(x, y);
        }
        else {

        }
    }
}
