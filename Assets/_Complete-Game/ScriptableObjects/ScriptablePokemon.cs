using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Completed
{
    [CreateAssetMenu(menuName = "Pokemon")]
    public class ScriptablePokemon : ScriptableObject
    {
        public Type type1;
        public Type type2;
        
        //[Header("Health Attributes")]
        public int MaxHealth;
        public Int2 HealthGrowth;
        //[Header("Attack Attributes")]
        public int Attack;
        public Int2 AttackGrowth;
        public int SAttack;
        public Int2 SAttackGrowth;

        //[Header("Defense Attributes")]
        public int Defense;
        public Int2 DefenseGrowth;
        public int SDefense;
        public Int2 SDefenseGrowth;

        public int[] moveLevels;
        public Scriptable.Move[] moves;

		public  RuntimeAnimatorController animatorController;
    }
}
