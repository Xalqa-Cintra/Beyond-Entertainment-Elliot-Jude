using UnityEngine;

public class SpriteBillBoard : MonoBehaviour
{ 
    private void Update()
    {
        transform.position = Quaternion.Euler(0f,Camera.main.transform.rotation.eulerAngles.y,0f);
    }
}
