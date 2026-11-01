using UnityEngine;
using UnityEngine.SceneManagement; //씬을 컨트롤 하기 위해서 필요한 네임 스페이스

public class ClearSceneManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
