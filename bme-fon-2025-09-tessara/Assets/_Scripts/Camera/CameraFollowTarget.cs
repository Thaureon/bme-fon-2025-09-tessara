using UnityEngine;

namespace Assets._Scripts.Camera
{
    public class CameraFollowTarget : MonoBehaviour
    {
        public Transform Target;

        // Update is called once per frame
        void Update()
        {
            gameObject.transform.position = new Vector3(Target.position.x, Target.position.y, gameObject.transform.position.z);
        }
    }
}
