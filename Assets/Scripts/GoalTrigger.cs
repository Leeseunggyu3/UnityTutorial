using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{
    [Header("Scene To Change")]
    [SerializeField] private string sceneToLoad;

   
    public void TriggerGoal()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.Log($"[GoalTrigger] 씬 '{sceneToLoad}' 로 이동");
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("[GoalTrigger] 이동할 씬 이름이 비어 있습니다!");
        }
    }
}
