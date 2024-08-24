using System;
using UnityEngine;
public class EnemyStatus : CharacterStatusBase
{
    [SerializeField, Tooltip("Ž‹–ì‚Ì”¼Œa")]
    float _viewRange = 5;
    [SerializeField, Tooltip("Ž‹–ì‚Ì”ÍˆÍ"), Range(0, 360)]
    float _viewAngle = 30;

    public override void Initialize()
    {

    }
}
