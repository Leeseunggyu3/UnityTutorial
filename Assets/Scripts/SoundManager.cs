using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [Header("효과음 소스")]
    public AudioSource sfxSource;

    [Header("효과음 클립들")]
    public AudioClip jumpClip;
    public AudioClip GoalClip;

    private void Awake()
    {
        // 싱글톤 패턴 (전역 접근)
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // 씬 이동해도 유지
        }
        else
        {
            Destroy(gameObject);  // 중복 방지
        }
    }

    // 외부에서 사용할 함수들
    public void PlayJump()
    {
        sfxSource.PlayOneShot(jumpClip);
    }
    public void PlayGoal()
    {

        sfxSource.PlayOneShot(GoalClip);
    }
}
