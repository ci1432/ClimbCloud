using UnityEngine;

public class Study : MonoBehaviour
{
    /*
     Physics에서 Rigidbody 컴포넌트는 힘계산(중력이나 마찰 등)을 담당 Collider 컴포넌트는 물체의 충돌 판정을 담당

    Circle Collider 2D 원형 콜라이더
    Box Collider 2D 사각형 콜라이더
    Edge Collider 2D 선형 콜라이더. 오브젝트 일부를 충돌 판정할 때 사용
    Polygon Collider 2D 다각형 콜라이더. 오브젝트에 정확히 맞도록 충돌 판정할 때 사용

    중력과 물리 연산의 영향을 무시하려면 Body Type에서 Kinematic을 선택

    transform.up * jumpForce = (0, jumpForce, 0)
    transform.right = (1, 0, 0)

    2D에서 좌, 우 반전을 해야할 때 하는 방법
    1. SpriteRenderer 컴포넌트에서 Flip의 x또는 y를 true한다.
    2. Rotation의 Y축을 180도 회전시킨다.
    3. Scale의 X축을 -1배한다.

    메카님(Mecanim)은 애니메이션을 작성하고 실행할 때 유니티 에디터에서 일관되게 조작할 수 있는 기능
    메카님을 사용하면, 게임을 설계할 때 스프라이트 애니메이션을 작성해 각 애니메이션의 교체 시기를 지정할 수 있음
    그러면 게임을 플레이할 때 메카님이 오브젝트 상태를 판단하고 자동으로 애니메이션을 바꿔 재생할 수 있음

    Physics를 사용한 충돌 판정 종류
    Collision모드 (충돌) Trigger 모드 (통과)

    충돌한 순간 OnCollisionEnter2D OnTriggerEnter2D
    충돌 중 OnCollisionStay2D OnTriggerStay2D
    충돌이 끝난 순간 OnCollisionExit2D OnTriggerExit2D
     */
}
