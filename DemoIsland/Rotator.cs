using Godot;
using System;

public class Rotator : Spatial
{

	public override void _Process(float delta) {
		Rotate(Vector3.Up, delta * 0.5f);
	}

}