using UnityEngine;
public interface IController
{
    Vector2 HorizontalMovement
    {
        get;
        set;
    }
    Vector2 VerticalMovement
    {
        get;
        set;
    }
    Vector2 Knockback
    {
        get;
        set;
    }
    void Execute();
    
}