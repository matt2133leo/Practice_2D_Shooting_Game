using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    [Header("黑色不明物血量")]
    public int black_hp = 10;

    [Header("目前血量")]
    public Text hpstring;

    [Header("黑色受傷音源")]
    public AudioSource blackhurtAud;

    [Header("黑色受傷音效")]
    public AudioClip blackhurtAC;


    /// <summary>
    /// 子彈射中黑色不明物扣血
    /// </summary>
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "子彈")
        {
            blackdead(); // 當子彈射過去時 黑色不明物血量為1 時 死亡
            playblacksound(); //黑色不明物音效
            black_hp = --black_hp; //hp扣血
            hpstring.text = black_hp.ToString(); //顯示black_hp血量
        }
    }

    /// <summary>
    /// 黑色不明物音效
    /// </summary>
    public void playblacksound()
    {
        blackhurtAud.PlayOneShot(blackhurtAC); //播放受傷音效
    }

    /// <summary>
    /// 黑色不明物死亡判定
    /// </summary>
    public void blackdead()
    {
        if (hpstring.text == "1") //血量為1時
        {
            Destroy(gameObject, 0.01f); //刪除黑色不明物
        }
    }
    #endregion
}
