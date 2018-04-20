using UnityEngine;

using System.Collections;

public class camreascript : MonoBehaviour

{

    //what we are following

    public Transform target;

    //zeros out the velocity

    Vector3 velocity = Vector3.zero;

    //time to follow target

    public float smoothTime = .15f;

    //enable and set maximum Y value

    public bool YMaxEnabled = false;

    public float YMaxValue = 0f;

    //enable and set min Y value

    public bool YMinEnabled = false;

    public float YMinValue = 0f;

    //enable and set X max vlaue

    public bool XMaxEnabled = false;

    public float XMaxValue = 0f;

    //enable and set X min value

    public bool XMinEnabled = false;

    public float XMinValue = 0f;

    void FixedUpdate()

    {

        //target position

        Vector3 targetPos = target.position;

        //vertical

        if (YMinEnabled && YMaxEnabled)

            //for the targets Y position we'll clamp that position between the Y min and the Y max

            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxValue);

        else if (YMinEnabled)

            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);

        else if (YMaxEnabled)

            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);

        //horizontal

        if (XMinEnabled && XMaxEnabled)

            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);

        else if (XMinEnabled)

            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, targetPos.x);

        else if (XMaxEnabled)

            targetPos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);

        //align the camera and the targets z position

        targetPos.z = transform.position.z;

        //using smooth damp we will gradually change the camera transform position to the target

        

transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

    }

}


