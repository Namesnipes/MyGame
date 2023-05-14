using Godot;
using System;

public partial class testing : Sprite2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        float AMOUNT = 5;
        if (Input.IsActionPressed("up"))
        {
            this.Position += new Vector2(0, -AMOUNT);
        }
        if (Input.IsActionPressed("right"))
        {
            this.Position += new Vector2(AMOUNT, 0);
        }
        if (Input.IsActionPressed("left"))
        {
            this.Position += new Vector2(-AMOUNT, 0);
        }
        if (Input.IsActionPressed("down"))
        {
            this.Position += new Vector2(0, AMOUNT);
        }
    }
}