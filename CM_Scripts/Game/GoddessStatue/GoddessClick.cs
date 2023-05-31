using UnityEngine;
using UnityEngine.EventSystems;
using Game.players;

public class GoddessClick : MonoBehaviour, IPointerClickHandler
{
    private GoddessDistanceCheck goddessDistanceCheck;
    private GoddessCheckItem goddessCheckItem;
    private PlayerMover playerMover;
    private PlayerHP playerHP;

    private void Start()
    {
        goddessDistanceCheck = GetComponent<GoddessDistanceCheck>();
        goddessCheckItem = GetComponent<GoddessCheckItem>();
        playerMover = GameObject.Find("PlayerManager").GetComponent<PlayerMover>();
        playerHP = FindObjectOfType<PlayerHP>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (goddessDistanceCheck.isNear == true)
        {
            playerMover.GoalSignal();
            Debug.Log("touch");
            if (goddessCheckItem.HaveSpecialItem()==false) return;

            playerHP.MaxHpPlus();
            //Textで表示させる
            Debug.Log("アイテムを消費して最大HPが増えました!");
        }
    }
}
