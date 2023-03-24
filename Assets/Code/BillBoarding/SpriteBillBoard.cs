using UnityEngine;

public class SpriteBillBoard : MonoBehaviour
{
    [SerializeField] bool FreezeXZAxis = true;

    private void LateUpdate()
    {
        if (FreezeXZAxis)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }

}
