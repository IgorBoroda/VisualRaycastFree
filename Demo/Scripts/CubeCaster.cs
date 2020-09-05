using SimpleMan.Utilities.Cast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCaster : MonoBehaviour
{
    //******     FIELDS AND PROPERTIES   	******\\
    public float castDistance = 10;
    public float originDistance = 2;
    public float castDelay = 0.5f;




    //******    	    METHODS  	  	    ******\\
    private void Start()
    {
        //Start the coroutine that will call 
        //"CastToForward" method every [castDelay] seconds
        StartCoroutine(Caster());
    }


    /// <summary>
    /// Raycast to forward
    /// </summary>
    private void CastToForward()
    {
        //Origin position of ray cast
        Vector3 l_originCastPosition = transform.position + transform.forward * originDistance;


        //Make raycast from origin position to forward
        CastResult l_castResult = SMCast.RayCast(this, l_originCastPosition, transform.forward, castDistance);



        //Did raycast hit something? => Paint the target 
        if (l_castResult)
        {

            //Get first casted game object (In the simple ray cast it only one)
            GameObject l_castedGameObject = l_castResult.GetFirstHit().collider.gameObject;


            //Change color of material on casted game object
            PaintCastTarget(l_castedGameObject, Color.white);
        }




    }



    /// <summary>
    /// Change color of material on target game object
    /// </summary>
    /// <param name="_target"> Target game object </param>
    /// <param name="_newColor"> New color </param>
    private void PaintCastTarget(GameObject _target, Color _newColor)
    {
        _target.GetComponent<MeshRenderer>().material.color = _newColor;
    }


    /// <summary>
    /// Calls CastToForward method every [castDelay] seconds
    /// </summary>
    /// <returns></returns>
    private IEnumerator Caster()
    {
        while (true)
        {
            CastToForward();
            yield return new WaitForSeconds(castDelay);
        }
    }
}
