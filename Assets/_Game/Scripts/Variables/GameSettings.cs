using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables;

[CreateAssetMenu(fileName = "new GameSettings", menuName = "ScriptableObjects/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField] public float throttlePower;
    [SerializeField] public float rotationPower;
    [SerializeField] public float damage;
    [SerializeField] public bool enableDamage;
}
