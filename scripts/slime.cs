using Godot;
using System;


public partial class slime : Node2D
{
	const float SPEED = 60;
	int direction = 1;
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 position = Position;

		position.X += direction * SPEED * (float)delta;
		Position = position;
	}
}
