using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;
using UnityEngine.Tilemaps;

[System.Serializable]
public class FloorManager : MonoBehaviour
{
    [System.Serializable]
    public class Occupant
    {
        public ScriptablePokemon basePokemon;
        [Range(1, 100)]
        public int maxLevel;
        [Range(1, 100)]
        public int minLevel;
    }
	[System.Serializable]
	public class FloorDetails
	{
		//TODO ADD TRAP TABLES, ITEM TABLES, 
		public int floorWidth, floorHeight, roomSize, relativeRoomNum;
		public bool hasShop, hasMonsterhouse;
	}

	public GameObject roomPrefab;
	public GameObject stairPrefab;
	[SerializeField]
	private GameObject pokemonPrefab;
	public FloorDetails details;
	public int maxOccupants = 20;
    public Occupant[] occupants;
    public static FloorManager instance;
	List<GameObject> _roomManagers;
	public TileBase walls;
	public TileBase floors;
	public TileBase roomFloor;

	private void Awake()
	{
		instance = this;
		_roomManagers = new List<GameObject>();
	}

	public void AddRoom(Rect parent)
	{
		GameObject roomHandler = Instantiate(roomPrefab, instance.transform);
		roomHandler.name = "roomManager: " + parent.x + "," + parent.y; 
		roomHandler.GetComponent<RoomManager>().BuildRoom(parent);

		_roomManagers.Add(roomHandler);

		BoxCollider2D tempCollider = roomHandler.GetComponent<BoxCollider2D>();
		roomHandler.transform.position = new Vector2(parent.x, parent.y);
		tempCollider.offset = new Vector2(parent.width / 2, parent.height / 2);
		tempCollider.size = new Vector2(parent.width, parent.height);
		tempCollider.isTrigger = true;

	}

	public RoomManager GetRandomRoom()
	{
		return _roomManagers[Random.Range(0, _roomManagers.Count - 1)].GetComponent<RoomManager>();
	}

    public void PlaceEnemies()
    {
        for (int i = 0; i < maxOccupants/2; i++)
		{
			Debug.Log("Placing Enemies");
			PlaceEnemy(occupants[Random.Range(0, occupants.Length - 1)]);
        }
    }

	public void PlaceEnemy(Occupant occupant)
	{
		RoomManager randomRoom = GetRandomRoom();
		//Instantiate a stair prefab at a random tile in the room
		TileStructure randomTile = randomRoom.GetRandomTile();
		Vector2 position = new Vector2(randomTile.location.x + .5f, randomTile.location.y + .6f);
		Debug.Log(position);
		GameObject tempPoke = Instantiate(pokemonPrefab, position, transform.rotation);
		tempPoke.GetComponent<Pokemon>().InitializePokemon(occupant.basePokemon, Random.Range(occupant.minLevel, occupant.maxLevel));
	}
	
	//TODO: add an override for placenemy that takes a location and places the enemy at that location

    public void PlaceItems()
    {

    }

    public void PlaceStairs()
    {
		//Choose a random room
		RoomManager randomRoom = GetRandomRoom();
		//Instantiate a stair prefab at a random tile in the room
		TileStructure randomTile = randomRoom.GetRandomTile();
		Vector2 position = new Vector2(randomTile.location.x+.5f, randomTile.location.y + .6f);
		Instantiate(stairPrefab, position, transform.rotation);
    }

	public void InitFloor()
	{
		_roomManagers.TrimExcess();

		//Add all exits to the roommanager so to allow for ai movement based on spanning trees
		foreach (GameObject roomManager in _roomManagers)
		{
			roomManager.GetComponent<RoomManager>().SetBorders();
		}

		int randomShop = Random.Range(0, _roomManagers.Count);
		int randomHouse = Random.Range(0, _roomManagers.Count);
		while (randomHouse == randomShop)
			randomHouse = Random.Range(0, _roomManagers.Count);
		

		for (int i = 0; i < _roomManagers.Count; i++)
		{
			if (details.hasShop)
			{
				if (i == randomShop)
				{
					_roomManagers[i].GetComponent<RoomManager>().InitRoom(RoomType.shop);
				}
			}
			else if (details.hasMonsterhouse)
			{
				if (i == randomHouse)
					_roomManagers[i].GetComponent<RoomManager>().InitRoom(RoomType.monsterHouse);
			}
			else
				_roomManagers[i].GetComponent<RoomManager>().InitRoom(RoomType.normal);

		}

		PlaceStairs();
		PlaceEnemies();
	}
}
