extends Node

# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
    var a = funcref(self, 'fun')
    var cs_class = preload('res://src/Scenes/StringSpec.cs')
    print(cs_class)
    cs_class.new()
    

func fun() -> bool:
    return true
# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#    pass
