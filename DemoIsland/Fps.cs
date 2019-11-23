using Godot;
using System;

public class Fps : Label
{

	public override void _Process(float delta)
	{
		this.Text = "FPS: " + Engine.GetFramesPerSecond();
	}

}