using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency
{
    private string name;
    private float value;
    private Texture2D icon;

    public string Name { get => name; set => name = value; }
    public float Value { get => value; set => this.value = value; }
    public Texture2D Icon { get => icon; set => icon = value; }
}
