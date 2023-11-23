using UnityEngine;

public class KeyboardControl : IControl
{
    private ControlSettings settings;

    public KeyboardControl(ControlSettings settings)
    {
        this.settings = settings;
    }

    public Vector2 GetDirection()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(settings.Forward))
            direction += Vector2.up;
        if (Input.GetKey(settings.Backward))
            direction += Vector2.down;
        if (Input.GetKey(settings.Right))
            direction += Vector2.right;
        if (Input.GetKey(settings.Left))
            direction += Vector2.left;

        return direction;
    }

    public Vector2 GetRotation()
    {
        return new Vector2(Input.GetAxis(Axes.MouseX), Input.GetAxis(Axes.MouseY));
    }

    public void LoadSettings(ControlSettings settings)
    {
        this.settings = settings;
    }
}