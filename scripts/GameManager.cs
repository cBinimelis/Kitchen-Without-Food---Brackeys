using Godot;
using System;

public partial class GameManager : Node
{
    public static int score = 0;

    public void AddPoints(){
        score +=1;
        GD.Print(score);
    }
}
