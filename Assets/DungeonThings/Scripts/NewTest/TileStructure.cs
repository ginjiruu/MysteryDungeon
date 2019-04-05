using UnityEngine;

public class TileStructure
{
	#region Variables
	public Vector2 location;
	public DungeonTile tileType;
	public bool isPartOfRoom = false;
	public bool occupied = false;
	#endregion


	public TileStructure(int _x, int _y)
	{
		location.x = _x;
		location.y = _y;
	}
	#region Other
	
	#endregion
}
