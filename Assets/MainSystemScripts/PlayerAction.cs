using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : CharacterActionBase
{
    public void GetInputMove(InputAction.CallbackContext context)
    {
        Vector2 axis = context.ReadValue<Vector2>();
        Moving(axis);
    }
}
