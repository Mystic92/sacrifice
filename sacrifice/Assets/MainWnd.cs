using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWnd : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    public GameObject subWnd1;
    public GameObject subWnd2;
    public GameObject subWnd3;
    public GameObject subWnd4;


    public Button desWndBtn;//�������ڰ�ť
    public Button VRBtn;//VR��ť
    public Button bookingBtn;//����ԤԼ
    public Button consultBtn;//������ѯ
    public Button aboutAsBtn;//��������
    public Button onlineSacrificeBtn;//���ϼ���
    public Button ecologyGraveBtn;//��̬Ĺ԰
    public Button cloudPhotoBtn;//�����
    public Button memoryBtn;//�������
    public Button TDImageBtn;//3d����
    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(OnBtnClick1);
        btn2.onClick.AddListener(OnBtnClick2);
        btn3.onClick.AddListener(OnBtnClick3);
        btn4.onClick.AddListener(OnBtnClick4);
        desWndBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("des");
        });
        VRBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("vr");
        });
        bookingBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("booking");
        });
        consultBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("consult");
        });
        aboutAsBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("des");
        });
        onlineSacrificeBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("onlineSacrifice");
        });
        ecologyGraveBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("ecologyGrave");
        });
        cloudPhotoBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("cloudPhoto");
        });
        memoryBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("memory");
        });
        TDImageBtn.onClick.AddListener(() => {
            UiMgr.instance.ShowWnd("TDImage");
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBtnClick1() {
        subWnd1.SetActive(true);
        subWnd2.SetActive(false);
        subWnd3.SetActive(false);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick2() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(true);
        subWnd3.SetActive(false);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick3() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(false);
        subWnd3.SetActive(true);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick4() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(false);
        subWnd3.SetActive(false);
        subWnd4.SetActive(true);
    }
}
