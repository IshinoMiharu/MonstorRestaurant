using System;
using UnityEngine;
public class EnemyStatus : CharacterStatusBase
{
    [SerializeField, Tooltip("����̔��a")]
    float _viewRange = 5;
    [SerializeField, Tooltip("����͈̔�"), Range(0, 360)]
    float _viewAngle = 30;

    public override void Initialize()
    {

    }
}
