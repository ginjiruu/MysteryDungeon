using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed.Scriptable
{
    public abstract class Move : ScriptableObject
    {
        public Type moveTyping;                 //Moves type for determining effectivness
        public MoveDamageType moveDamageType;   //moves type for determining defense resistance
        public int maxpp;                       //Moves maximum pp
        public int damage;                      //Move damage if any
        public int accuracy;                    //Move Accuracy
        public int critRange;
        public AudioClip soundEffect;           //Sound effect to be played when used
        public LayerMask blockingLayer;			//Layer on which collision will be checked.
        public WallInteraction wallType;        //If the move can go around corners


        public UI_Info ui_info;

        public Runtime runtime;

        public class Runtime
        {
            public int pp;
        }

        [System.Serializable]
        public class UI_Info
        {
            public string moveName;
            public string moveDescription;
        }

        public abstract void DoMove(Pokemon source);
        public virtual void DoDamage(Pokemon target)
        {
            float test = damage * 1.25f;
            if(Random.Range(0f, 100f) < critRange)
                target.pokemonStats.TakeDamage( (int) test, moveTyping);
            else
                target.pokemonStats.TakeDamage(damage, moveTyping);
        }
    }
    
    public enum MoveDamageType
    {
        physical, special, effect
    }

    public enum WallInteraction
    {
        cannot, around, through
    }
}