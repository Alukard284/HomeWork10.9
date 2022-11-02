using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    //UI
    [SerializeField] Image _startScreen;
    [SerializeField] Button _pinBallButton;
    [SerializeField] Button _hammerButton;
    [SerializeField] Button _exitButton;
    //Игровые объекты
    [SerializeField] GameObject Pinball;
    [SerializeField] GameObject Hammer;

    [SerializeField] Camera _camera;
    //Трансформ камеры в зависимости от выбранного объекта
    private Vector3 _pinballCameraTransform = new Vector3(5.7f, 87.1f, -21);
    private Quaternion _pibbalCameraRotate = Quaternion.Euler(75f, 0f, 0f);

    private Vector3 _hammerCameraTransform = new Vector3(448f ,44f, -130f);
    private Quaternion _hammerCameraRotate = Quaternion.Euler(0f, 0f, 0f);
    
    //Активация PinBall
    public void PinballLoadButton()
    {
        _startScreen.gameObject.SetActive(false);
        _pinBallButton.gameObject.SetActive(false);
        _hammerButton.gameObject.SetActive(false);
        _exitButton.gameObject.SetActive(true);
        Pinball.gameObject.SetActive(true);
        _camera.transform.position = _pinballCameraTransform;
        _camera.transform.rotation = _pibbalCameraRotate;   
    }

    //Активация Hammer
    public void HammerLoadButton()
    {
        _startScreen.gameObject.SetActive(false);
        _pinBallButton.gameObject.SetActive(false);
        _hammerButton.gameObject.SetActive(false);
        _exitButton.gameObject.SetActive(true);
        Hammer.gameObject.SetActive(true);
        _camera.transform.position = _hammerCameraTransform;
        _camera.transform.rotation = _hammerCameraRotate;
    }

    public void ExitButton()
    {
        Pinball.SetActive(false);
        Hammer.SetActive(false);
        _startScreen.gameObject.SetActive(true);
        _pinBallButton.gameObject.SetActive(true);
        _hammerButton.gameObject.SetActive(true);
        _exitButton.gameObject.SetActive(false);
        //Перезагрузка текущей сцены
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
