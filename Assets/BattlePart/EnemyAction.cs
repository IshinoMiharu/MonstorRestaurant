using UnityEngine;

public class EnemyAction : CharacterActionBase
{
    Transform player;
    public override void Initialize()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    {
        Vector2 axis = player.transform.position - transform.position;
        Moving(axis);
    }
}
