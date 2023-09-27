using Godot;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class PlayTweenExample : Node
{
	[Export] public Node2D NodeToMove;
	
	public override void _Ready()
	{
		GTween tween = NodeToMove.TweenPosition(new Vector2(100, 0), 3);
		tween.SetEasing(Easing.InOutCubic);
		tween.Play();
	}
}