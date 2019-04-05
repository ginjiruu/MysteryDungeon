using UnityEngine;
using System.Collections;

namespace Completed
{
	public class Wall : MonoBehaviour
	{
		public AudioClip chopSound1;				//1 of 2 audio clips that play when the wall is attacked by the player.
		public AudioClip chopSound2;				//2 of 2 audio clips that play when the wall is attacked by the player.
		public int hp = 1;							//hit points for the wall.
		
		
		private SpriteRenderer spriteRenderer;		//Store a component reference to the attached SpriteRenderer.
		
		
		void Awake ()
		{
			//Get a component reference to the SpriteRenderer.
			spriteRenderer = GetComponent<SpriteRenderer> ();
		}
		
		
		//DamageWall is called when the player attacks a wall.
		public void DamageWall (int loss)
		{
			//Call the RandomizeSfx function of SoundManager to play one of two chop sounds.
			SoundManager.instance.RandomizeSfx (chopSound1, chopSound2);
			
			//Subtract loss from hit point total.
			hp -= loss;

			//If hit points are less than or equal to zero:
			if (hp <= 0)
				MakeFloor();
		}

		private void MakeFloor()
		{

			//if(DungeonGenerator.instance.IsRoomTile(new Int2((int)transform.position.x, (int)transform.position.y)))
			//{
			//	//if this tile is part of a room. Add this room to the connecting room
			//}
			//else
			//{
			//	//
			//}


			DungeonGenerator.instance.tilemap.SetTile(new Vector3Int(
														(int)transform.position.x,
														(int)transform.position.y,
														(int)transform.position.z),
														DungeonGenerator.instance.floors);
			Destroy(this);
		}
	}
}
