using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    void Update()
    {
        // R 키를 누르면 현재 활성화된 씬을 다시 로드합니다.
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 현재 씬 이름을 가져와서 다시 로드
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
