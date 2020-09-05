using System;
using System.Collections;
using System.Linq;
using TMPro.EditorUtilities;
using UnityEngine;

namespace SimpleMan.Utilities.Cast
{
    public static class SMCast
    {

        #region RAY CAST
        /// <summary>
        /// Raycasting with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will compute drawing visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_drawLine"> Do you want to draw the debug line? </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCast(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, bool _drawLine = true, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();


            //Cast hit
            RaycastHit l_hit;



            //Hit something? => Add hit as result
            if (Physics.Raycast(_originPosition, _direction, out l_hit, _distance))
                l_castResult.hits = new RaycastHit[] { l_hit };



#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetFirstHit().point, Color.green, _rayLifeTime));


                else
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
            }
            if (_drawLine) { DrawLine(); }
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_layerMask"> Objects in this layers can be casted </param>
        /// <param name="_drawLine"> Do you want to draw the debug line? </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCast(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, LayerMask _layerMask, bool _drawLine = true, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();


            //Cast hit
            RaycastHit l_hit;



            //Hit something? => Add hit as result
            if (Physics.Raycast(_originPosition, _direction, out l_hit, _distance, _layerMask))
                l_castResult.hits = new RaycastHit[] { l_hit };


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetFirstHit().point, Color.green, _rayLifeTime));


                else
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
            }
            if (_drawLine) { DrawLine(); }
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_noHitColor"> Color of debug ray if no hit </param>
        /// <param name="_hitColor"> Color of debug ray if hit </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCast(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, Color _noHitColor, Color _hitColor, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();


            //Cast hit
            RaycastHit l_hit;



            //Hit something? => Add hit as result
            if (Physics.Raycast(_originPosition, _direction, out l_hit, _distance))
                l_castResult.hits = new RaycastHit[] { l_hit };


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetFirstHit().point, _hitColor, _rayLifeTime));


                else
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
            }
            DrawLine();
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_layerMask"> Objects in this layers can be casted </param>
        /// <param name="_noHitColor"> Color of debug ray if no hit </param>
        /// <param name="_hitColor"> Color of debug ray if hit </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCast(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, LayerMask _layerMask, Color _noHitColor, Color _hitColor, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();


            //Cast hit
            RaycastHit l_hit;



            //Hit something? => Add hit as result
            if (Physics.Raycast(_originPosition, _direction, out l_hit, _distance, _layerMask))
                l_castResult.hits = new RaycastHit[] { l_hit };


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetFirstHit().point, _hitColor, _rayLifeTime));


                else
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
            }
            DrawLine();
#endif


            return l_castResult;
        }
        #endregion




        #region RAY CAST ALL
        /// <summary>
        /// Raycasting all with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will compute drawing visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_drawLine"> Do you want to draw the debug line? </param>
        /// <param name="_rayLifeTime"> </param>
        /// <returns></returns>
        public static CastResult RayCastAll(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, bool _drawLine = true, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();



            //Hit something? => Add hit as result
            l_castResult.hits = (Physics.RaycastAll(_originPosition, _direction, _distance));



#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetLastHit().point, Color.green, _rayLifeTime));
                    _sender.StartCoroutine(LineDrawer(l_castResult.GetLastHit().point, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
                }


                else
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
                }
            }
            if (_drawLine) { DrawLine(); }
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting all with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_layerMask"> Objects in this layers can be casted </param>
        /// <param name="_drawLine"> Do you want to draw the debug line? </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCastAll(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, LayerMask _layerMask, bool _drawLine = true, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();



            //Hit something? => Add hit as result
            l_castResult.hits = (Physics.RaycastAll(_originPosition, _direction, _distance, _layerMask));


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetLastHit().point, Color.green, _rayLifeTime));
                    _sender.StartCoroutine(LineDrawer(l_castResult.GetLastHit().point, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
                }


                else
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, Color.red, _rayLifeTime));
                }
            }
            if (_drawLine) { DrawLine(); }
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting all with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_noHitColor"> Color of debug ray if no hit </param>
        /// <param name="_hitColor"> Color of debug ray if hit </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCastAll(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, Color _noHitColor, Color _hitColor, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();



            //Hit something? => Add hit as result
            l_castResult.hits = (Physics.RaycastAll(_originPosition, _direction, _distance));


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetLastHit().point, _hitColor, _rayLifeTime));
                    _sender.StartCoroutine(LineDrawer(l_castResult.GetLastHit().point, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
                }


                else
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
                }
            }
            DrawLine();
#endif


            return l_castResult;
        }


        /// <summary>
        /// Raycasting all with visual ray  
        /// </summary>
        /// <param name="_sender"> Class that will draw visual ray by using a Coroutine. Just write keyword "this" in current paramerer </param>
        /// <param name="_originPosition"> Origin position of your ray </param>
        /// <param name="_direction"> Ray direction </param>
        /// <param name="_distance"> Raycast distance </param>
        /// <param name="_layerMask"> Objects in this layers can be casted </param>
        /// <param name="_noHitColor"> Color of debug ray if no hit </param>
        /// <param name="_hitColor"> Color of debug ray if hit </param>
        /// <param name="_rayLifeTime"> Life time of debug ray </param>
        /// <returns></returns>
        public static CastResult RayCastAll(MonoBehaviour _sender, Vector3 _originPosition, Vector3 _direction, float _distance, LayerMask _layerMask, Color _noHitColor, Color _hitColor, float _rayLifeTime = 0.5f)
        {

            CastResult l_castResult = new CastResult();



            //Hit something? => Add hit as result
            l_castResult.hits = (Physics.RaycastAll(_originPosition, _direction, _distance, _layerMask));


#if UNITY_EDITOR
            //Draw the debug line
            void DrawLine()
            {
                if (l_castResult)
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, l_castResult.GetLastHit().point, _hitColor, _rayLifeTime));
                    _sender.StartCoroutine(LineDrawer(l_castResult.GetLastHit().point, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
                }


                else
                {
                    _sender.StartCoroutine(LineDrawer(_originPosition, _originPosition + _direction * _distance, _noHitColor, _rayLifeTime));
                }
            }
            DrawLine();
#endif


            return l_castResult;
        }
        #endregion




        /// <summary>
        /// Draw debug line with fade in effect
        /// </summary>
        /// <param name="_originPosition"> Origin position of line </param>
        /// <param name="_targetPosition"> End position of line </param>
        /// <param name="_color"> Line color </param>
        /// <param name="_time"> Life time of debug line </param>
        /// <returns></returns>
        private static IEnumerator LineDrawer(Vector3 _originPosition, Vector3 _targetPosition, Color _color, float _time = 0.5f)
        {

            //Seconds left
            float l_timeLeft = _time;


            //Draw line while time is not spend
            while (l_timeLeft > 0)
            {

                //Get current opacity of drawing line
                //(Fade in effect)
                Color l_GetCurrentLineColor()
                {
                    float l_currentOpacity = 1 / (_time / l_timeLeft);
                    return new Color(_color.r, _color.g, _color.b, l_currentOpacity);
                }


                //Draw line
                Debug.DrawLine(_originPosition, _targetPosition, l_GetCurrentLineColor());


                //Decrease time
                l_timeLeft -= Time.deltaTime;


                yield return null;
            }
        }
    }
}
