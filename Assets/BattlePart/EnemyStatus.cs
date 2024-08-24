using System;
using UnityEngine;
public class EnemyStatus : CharacterStatusBase
{
    Transform player;
    EnemyAction action;

    [SerializeField, Tooltip("Ž‹–ì‚Ì”¼Œa")]
    float _viewRange = 5;
    [SerializeField, Tooltip("Ž‹–ì‚Ì”ÍˆÍ"), Range(90, 360)]
    float _viewAngle = 30;

    public override void Initialize()
    {
        action = GetComponent<EnemyAction>();
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        Vector2 playerAxis = player.position - transform.position;
        float angle = Vector2.Angle(transform.right, playerAxis);
        if (angle <= _viewAngle)
        {
            action.Moving(playerAxis);

        }
    }
}
