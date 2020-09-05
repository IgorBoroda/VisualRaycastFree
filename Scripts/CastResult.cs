using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleMan.Utilities.Cast
{

    public class CastResult
    {
        /// <summary>
        /// Cast hits
        /// </summary>
        public RaycastHit[] hits = new RaycastHit[] { };


        /// <summary>
        /// Get first cast hit
        /// </summary>
        /// <returns></returns>
        public RaycastHit GetFirstHit()
        {
            if (hits.Length > 0) return hits[0];


            return new RaycastHit();
        }


        /// <summary>
        /// Get last cast hit
        /// </summary>
        /// <returns></returns>
        public RaycastHit GetLastHit()
        {
            if (hits.Length > 0)
                return hits[hits.Length - 1];


            return new RaycastHit();
        }


        public static bool operator true(CastResult _castResult) => _castResult.hits.Length > 0;


        public static bool operator false(CastResult _castResult) => _castResult.hits.Length == 0;


    }
}
