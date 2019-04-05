using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed.Scriptable;

namespace Completed
{
    public abstract class Pokemon : MovingObject
    {
        [System.Serializable]
        public class Stats
        {
            public Type type1;
            public Type type2;

            public int Level { get; set; }
            public int Exp { get; set; }
            public int ExpToNext { get; set; }
            //[Header("Health Attributes")]
            public int CurHealth { get; set; }
            public int MaxHealth { get; set; }
            public int HealthGrowth { get; set; }
            //[Header("Attack Attributes")]
            public int CurAttack { get; set; }
            public int Attack { get; set; }
            public int AttackGrowth { get; set; }
            public int SAttack { get; set; }
            public int CurSAttack { get; set; }
            public int SAttackGrowth { get; set; }

            //[Header("Defense Attributes")]
            public int Defense { get; set; }
            public int CurDefense { get; set; }
            public int DefenseGrowth { get; set; }
            public int SDefense { get; set; }
            public int CurSDefense { get; set; }
            public int SDefenseGrowth { get; set; }
            
            public int MovementSpeed { get; set; }
            public int Accuracy { get; set; }

            private static float Effectivness(Type damageType, Type targetType1)
            {
                float totalMultiplier = 1f;
                switch (damageType)
                    {
                        case Type.normal:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    totalMultiplier *= .5f;
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.fire:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.fighting:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ice:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.bug:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.water:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.flying:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.grass:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.flying:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.grass:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.poison:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.poison:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.poison:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.fairy:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.electrick:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.flying:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.grass:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ground:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.ground:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.grass:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.poison:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.psychic:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.rock:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.fighting:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.bug:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.ice:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.flying:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.grass:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.bug:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.grass:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.poison:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.dark:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.dragon:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.ghost:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    totalMultiplier *= 0f;
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.dark:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.dark:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.dark:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.steel:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ice:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.fairy:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fighting:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    totalMultiplier *= 1.5f;
                                    break;
                                case Type.steel:
                                    totalMultiplier *= .75f;
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Type.empty:
                            switch (targetType1)
                            {
                                case Type.normal:
                                    break;
                                case Type.fire:
                                    break;
                                case Type.fighting:
                                    break;
                                case Type.water:
                                    break;
                                case Type.flying:
                                    break;
                                case Type.grass:
                                    break;
                                case Type.poison:
                                    break;
                                case Type.electrick:
                                    break;
                                case Type.ground:
                                    break;
                                case Type.psychic:
                                    break;
                                case Type.rock:
                                    break;
                                case Type.ice:
                                    break;
                                case Type.bug:
                                    break;
                                case Type.dragon:
                                    break;
                                case Type.ghost:
                                    break;
                                case Type.dark:
                                    break;
                                case Type.steel:
                                    break;
                                case Type.fairy:
                                    break;
                                case Type.empty:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                
                return totalMultiplier;
            }
            
            
            public void TakeDamage(int _damage, Type damageType)
            {
                _damage =  (int) (_damage * (Effectivness(damageType, type1) * Effectivness(damageType, type2)));
            }
        }
        public Stats pokemonStats;
		public ScriptablePokemon basePokemon;

        public bool isPartner;
        public bool isLeader;

		public Move[] currentMoves;
        public List<Move> learnableMoves = new List<Move>();
        Dictionary<int, Move> learnableMoveslevels = new Dictionary<int, Move>();

        public abstract void UseMove(Move _move);

        public void LevelUp()
        {
            pokemonStats.Level++;
            pokemonStats.ExpToNext = pokemonStats.ExpToNext * 2;
        }

        public void InitializePokemon(ScriptablePokemon scriptablePokemon, int level)
        {
			animator = GetComponent<Animator>();
			animator.runtimeAnimatorController = scriptablePokemon.animatorController;
			basePokemon = scriptablePokemon;
			currentMoves = new Move[4];
			int curMove = 0;
            int CurCurMove = 0;
            pokemonStats.Level = level;
            //StatCalculation Calculation
            for(int i = 0; i < level; i++)
			{
				Debug.Log(currentMoves.Length);
				pokemonStats.MaxHealth += Random.Range(scriptablePokemon.HealthGrowth.x, scriptablePokemon.HealthGrowth.y);
                pokemonStats.Attack += Random.Range(scriptablePokemon.AttackGrowth.x, scriptablePokemon.AttackGrowth.y);
                pokemonStats.SAttack += Random.Range(scriptablePokemon.SAttackGrowth.x, scriptablePokemon.SAttackGrowth.y);
                pokemonStats.Defense += Random.Range(scriptablePokemon.DefenseGrowth.x, scriptablePokemon.DefenseGrowth.y);
                pokemonStats.SDefense += Random.Range(scriptablePokemon.SDefenseGrowth.x, scriptablePokemon.SDefenseGrowth.y);

                if (scriptablePokemon.moveLevels[CurCurMove] == i)
                {
					Move temp = scriptablePokemon.moves[CurCurMove];
                    currentMoves[curMove] = temp;
                    if (curMove == 3)
                        curMove = 0;
                    else curMove++;
                    CurCurMove++;
                }
            }

            for (int i = 0; i < scriptablePokemon.moveLevels.Length; i++)
            {
                learnableMoveslevels.Add(scriptablePokemon.moveLevels[i], scriptablePokemon.moves[i]);
            }
        }
    }

    public enum Type
    {
        normal, fire, fighting, water, flying, grass, poison, electrick, ground, psychic, rock, ice, bug, dragon, ghost, 
        dark, steel, fairy, empty
    }
}
