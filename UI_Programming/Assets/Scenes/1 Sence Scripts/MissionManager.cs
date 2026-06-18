using UnityEngine;

public class MissionManager : MonoBehaviour
{
    // 1번째 미션 버튼 클릭 시
    public void OnClickMission1(GameObject missionUI)
    {
        Debug.Log("미션 1번 클릭");
    }

    // 2번째 미션 (보상 받기 버튼) 클릭 시
    public void OnClickMission2(GameObject missionUI)
    {
        Debug.Log(" 리워드 획득! 보상을 지급합니다.");

        // 1. 여기에 실제 플레이어에게 몬스터볼이나 재화를 지급하는 코드가 들어갑니다.
        // 예: PlayerInventory.AddMonsterBall(1); 

        // 2. 이 미션 버튼(칸 전체)을 화면에서 사라지게 만듭니다.
        if (missionUI != null)
        {
            missionUI.SetActive(false);
        }
    }

    // 3번째 미션 버튼 클릭 시
    public void OnClickMission3(GameObject missionUI)
    {
        Debug.Log("미션 3번 클릭");
    }

    // 4번째 미션 버튼 클릭 시
    public void OnClickMission4(GameObject missionUI)
    {
        Debug.Log("미션 4번 클릭");
    }
}