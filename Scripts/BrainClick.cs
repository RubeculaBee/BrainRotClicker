using Godot;
using System;

public partial class BrainClick : Sprite2D
{
	public override void _Ready()
	{
		Button button = GetChild<Button>(0);

		button.ButtonDown += _OnClick;
	}

	private void _OnClick()
	{
		GD.Print("Clicked!");
	}
}
