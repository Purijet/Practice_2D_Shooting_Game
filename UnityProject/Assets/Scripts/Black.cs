using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("血量")]
    public int Hp = 10;
    [Header("血量介面")]
    public Text TextHp;
    [Header("音效介面")]
    public AudioSource Aud;
    public AudioClip SoundHit;

    private void Hurt()
    {
        
    }
    #endregion
}
