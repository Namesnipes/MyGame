using Godot;
using System;

public partial class window : Node2D
{
	private bool clicked = false;
	private float width = 0.0f;
	private float height = 0.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(clicked){
			width = 500.0f;
			height = 500.0f;
			
		}
		else{
			width = 0.0f;
			height = 0.0f;
		}
		QueueRedraw();
	}
	public override void _Draw()
	{
    	DrawRect(new Rect2(GetViewport().GetVisibleRect().Size.X/2.0f, GetViewport().GetVisibleRect().Size.Y/2.0f, width, height), Colors.DarkRed);
	}
	public void SetClicked(bool click){
		clicked = click;
	}
}
