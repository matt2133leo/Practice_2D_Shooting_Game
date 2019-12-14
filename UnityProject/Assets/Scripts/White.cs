using UnityEngine;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("子彈")]
    public GameObject bullet;

    [Header("發射點")]
    public Transform shootingpoint;

    [Header("發射音源")]
    public AudioSource ShootingAud;

    [Header("發射音效")]
    public AudioClip ShootingAC;

    private void Update()
    {
        shootingmethod(); //射擊方法
    }


    /// <summary>
    /// 射擊方法
    /// </summary>
    public void shootingmethod()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Instantiate(bullet, shootingpoint);

            ShootingAud.PlayOneShot(ShootingAC);
        }
    }


    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

 /*   [Header("白色不明物的Scale")]
    public Transform Whitebio;*/


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    public void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);

     /*   if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Whitebio.localScale = new Vector3(-0.5f, 0.5f, 1f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Whitebio.localScale = new Vector3(0.5f, 0.5f, 1f);
        }
      */
    }
    #endregion
}