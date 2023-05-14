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
		if(mouseEvent.Position.X <= this.Position.X + (float)this.Texture.GetWidth()/2 &&
			mouseEvent.Position.X >= this.Position.X - (float)this.Texture.GetWidth()/2 &&
			mouseEvent.Position.Y <= this.Position.Y + (float)this.Texture.GetHeight()/2 &&
			mouseEvent.Position.Y >= this.Position.Y - (float)this.Texture.GetHeight()/2){

		GD.Print("Clicked Cat");
		w.SetClicked(true);
		}
		else{
			w.SetClicked(false);
		}
    }
	}
}
