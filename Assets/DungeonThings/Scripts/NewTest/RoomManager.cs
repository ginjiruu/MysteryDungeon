using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

[System.Serializable]
public class RoomManager : MonoBehaviour
{
    public Dictionary<Int2, TileStructure> tiles = new Dictionary<Int2, TileStructure>();
	public RoomType roomType;
	public int width, height, x, y;
	private bool IsInitialized { get; set; }
	public List<GameObject> unitsInside;
	public List<Vector2> exits;

    public void BuildRoom(Rect _roomRect)
	{
		exits = new List<Vector2>();
		Debug.Log("Building Room");
		width =(int) _roomRect.width;
		height = (int) _roomRect.height;
		x = (int) _roomRect.x;
		y = (int) _roomRect.y;

		for (int _x  = x; _x < width+ x; _x++)
		{
			for (int _y = y; _y < height + y; _y++)
			{
				Int2 temp = new Int2(_x, _y);
				tiles.Add(temp, DungeonGenerator.instance.allTiles[((_y - 1) * DungeonGenerator.instance._dungeonWidth) + _x]);
			}
		}
	}

	public TileStructure GetRandomTile()
	{
		Int2 testInt = new Int2(Random.Range(x, x + width), Random.Range(y, y + height));

		//foreach (KeyValuePair<Int2, TileStructure> item in tiles)
		//{
		//	Debug.Log(item.Value + " " + item.Key);
		//}
		return tiles[testInt];
	}

	//TODO: Add Place method for items
	public void AddTile(Vector2 vector)
	{
		Int2 temp = new Int2((int)vector.x, (int)vector.y);
		

		//Use the GetRandomTile method to find some random tile within the this tiles collection
		TileStructure tempTile = GetRandomTile();
		//using that random tile set the new tiles parent in the dungeonGenerators disjoint set of all
		//tiles to be that tiles parent. 
		DungeonGenerator.instance.tileArray.Parent[(((int)vector.y - 1) * DungeonGenerator.instance._dungeonWidth) + (int)vector.x]
			= (((int)tempTile.location.y - 1) * DungeonGenerator.instance._dungeonWidth) + (int)tempTile.location.x;

		//Adding the tile to this rooms dictionary of tiles
		//It gets the tile from the dungeonGenerators list of all tile structures.
		tiles.Add(temp, DungeonGenerator.instance.allTiles
			[(((int)vector.y - 1) * DungeonGenerator.instance._dungeonWidth) + (int)vector.x]);
	}

	public void SetBorders()
	{
		for (int _x = width-1; _x < x+width+1; _x++)
		{
			Vector2 top = new Vector2(_x, y - 1);
			Vector2 bottom = new Vector2(_x, y + height + 1);
			if (DungeonGenerator.instance.GetTile(new IntVector2(top)) == DungeonTile.Door)
			{
				exits.Add(top);
			}
			AddTile(top);
			if (DungeonGenerator.instance.GetTile(new IntVector2(bottom)) == DungeonTile.Door)
			{
				exits.Add(top);
			}
			AddTile(bottom);
		}

		for (int _y = height - 1; _y < y + height + 1; _y++)
		{
			Vector2 left = new Vector2(x - 1, _y);
			Vector2 right = new Vector2(x + width + 1, _y);
			if (DungeonGenerator.instance.GetTile(new IntVector2(left)) == DungeonTile.Door)
			{
				exits.Add(left);
			}

			if (DungeonGenerator.instance.GetTile(new IntVector2(right)) == DungeonTile.Door)
			{
				exits.Add(right);
			}
			AddTile(left);
			AddTile(right);
		}
	}

	public void InitRoom(RoomType _roomType)
	{
		roomType = _roomType;
		unitsInside = new List<GameObject>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.GetComponent<MovingObject>())
		{
			unitsInside.Add(collision.gameObject);
		}
	}

	

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.GetComponent<MovingObject>())
		{
			unitsInside.Remove(other.gameObject);
		}
	}
}
public enum RoomType
{
    monsterHouse, shop, treasure, trap, normal
}
