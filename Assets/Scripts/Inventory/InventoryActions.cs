using UnityEngine;
public class InventoryActions : MonoBehaviour
{
    //������ �������� � ���� ����� ���������
    [SerializeField] GameObject Slots;

    //���������� ������ 
    int clicksCounter = 0;

    //�������� ������ ��� �������� ������� �� ������ ��������� � ��� ��������/��������
    public void Action()
    {
        if (clicksCounter % 2 == 0)
            Slots.SetActive(false);
        else
            Slots.SetActive(true);
    }

    //������� ������
    public void Clicked()
    {
        clicksCounter++;

    }

}
