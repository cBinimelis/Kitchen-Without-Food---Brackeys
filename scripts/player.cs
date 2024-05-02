using Godot;
using System;

public partial class player : CharacterBody2D
{
	AnimatedSprite2D playerSprite;
	public const float Speed = 100.0f;
	public const float JumpVelocity = -300.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _Ready()
	{
		playerSprite = GetNode<AnimatedSprite2D>("playerSprite");
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
			velocity.Y = JumpVelocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("move_left", "move_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		//Play animations
		if (IsOnFloor())
		{
			if (direction.X > 0)
			{
				playerSprite.FlipH = false;
				playerSprite.Animation = "Run";
			}
			else if (direction.X < 0)
			{
				playerSprite.FlipH = true;
				playerSprite.Animation = "Run";
			}
			else
				playerSprite.Animation = "Idle";
		}
		else
		{
			playerSprite.Animation = "Jumping";
		}


		Velocity = velocity;
		MoveAndSlide();
	}
}
