using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed.Scriptable
{
    [CreateAssetMenu(menuName ="Move/LineMove")]
    public class LineMove : Move
    {
        public int range;
        public bool pierce;
        private void GetTargets(int _range, Pokemon _origin)
        {
            //Store start position to move from, based on objects current transform position.
            Vector2 start = _origin.transform.position;

            // Calculate end position based on the direction parameters passed in when calling Move.
            Vector2 end = start + new Vector2(_origin.transform.forward.x * _range, _origin.transform.forward.y * _range);

            RaycastHit2D[] hit = Physics2D.RaycastAll(start, end, blockingLayer);
            
            foreach(RaycastHit2D _hit in hit)
            {
                switch (wallType)
                {
                    case WallInteraction.cannot:
                        if (_hit.transform.gameObject.GetComponent<Wall>())
                        {
                            return;
                        }else
                        if(_hit.transform.gameObject.GetComponent<Pokemon>())
                        {
                            MoveLogic(_hit.transform.gameObject.GetComponent<Pokemon>());
                            if (!pierce)
                                return;
                        }
                            break;
                    case WallInteraction.around:
                        if (_hit.transform.gameObject.GetComponent<Pokemon>())
                        {
                            MoveLogic(_hit.transform.gameObject.GetComponent<Pokemon>());
                            if (!pierce)
                                return;
                        }
                        break;
                    case WallInteraction.through:
                        if (_hit.transform.gameObject.GetComponent<Pokemon>())
                        {
                            MoveLogic(_hit.transform.gameObject.GetComponent<Pokemon>());
                            if (!pierce)
                                return;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public override void DoMove(Pokemon source)
        {
            GetTargets(range, source);
        }

        public virtual void MoveLogic(Pokemon target)
        {
            target.pokemonStats.TakeDamage(damage, moveTyping);
        }
    }
}