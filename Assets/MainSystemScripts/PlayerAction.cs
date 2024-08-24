using UnityEngine;

public class PlayerAction : CharacterActionBase
{
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        Moving(new Vector2(horizontal, Vertical));
    }
}
