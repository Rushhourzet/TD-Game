using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FieldData", menuName = "ScriptableObjects/Field", order = 1)]
public class FieldData : ScriptableObject {
    public int width;
    public int thickness;
    public int height;
}
