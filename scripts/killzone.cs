using Godot;
using System;

public partial class killzone : Area2D
{
    private Timer _timer = new();
    
    public override void _Ready()
    {
        _timer = GetNode<Timer>("Timer");
    }

    private void OnBodyEntered(PhysicsBody2D body){
        body.GetNode<AnimatedSprite2D>("AnimatedSprite2D").Stop();
        body.Dispose();

        GD.PrintRich("[shake]GAME OVER[/shake]");
        _timer.Start();
    }

    private void OnTimeout(){
        GetTree().ReloadCurrentScene();
    }
    
}
