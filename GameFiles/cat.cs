using Godot;
using System;

public partial class cat : Sprite2D
{

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {

    }
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseEvent && mouseEvent.Pressed)
        {
            window w = GetParent().GetNode<window>("window");
            GD.Print(this.GetGlobalMousePosition());
            GD.Print(this.ToLocal(this.GetGlobalMousePosition()));
            if (this.GetRect().HasPoint(this.ToLocal(this.GetGlobalMousePosition())))
            {

                GD.Print("Clicked Cat");
                w.SetClicked(true);
            }
            else
            {
                w.SetClicked(false);
            }
        }
    }
}
