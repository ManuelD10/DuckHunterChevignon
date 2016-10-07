#pragma strict

var frames : Sprite[];
var framesPerSecond = 10.0;

private var timer = 0.0;


function Start () {

}

function Update () {
	timer = (timer + Time.deltaTime * framesPerSecond) % frames.Length;

	GetComponent(SpriteRenderer).sprite = frames[timer];
}