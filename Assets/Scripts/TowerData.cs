using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerData", menuName = "ScriptableObjects/Tower", order = 1)]
public class TowerData : ScriptableObject {
    public float cost;
    public float minDamage;
    public float maxDamage;
    public float speed;
    public float range;
    public float turnRate;

    public GameObject towerPrefab; //maybe use Mesh later
}
