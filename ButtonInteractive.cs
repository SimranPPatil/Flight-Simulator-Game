using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.UI;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ButtonInteractive : MonoBehaviour
    {
        [SerializeField] private Color m_NormalColor;
        [SerializeField] private Canvas m_Canvas;
        [SerializeField] private Canvas m_Canvas_tutorial;
        [SerializeField] private Button m_Button;
        [SerializeField] private Button m_Button2;
        [SerializeField] private Button m_Button3;
        [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private Renderer m_Renderer;
        [SerializeField] private Collider m_Collider;
        [SerializeField] private Text m_Text;
        [SerializeField] private Image m_Image;
        private void Awake()
        {
           // m_Renderer.material = m_NormalColor;
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_InteractiveItem.OnClick += HandleClick;
            m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_InteractiveItem.OnClick -= HandleClick;
            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
        }

        //Handle the Over event
        private void HandleOver()
        {
            Debug.Log("Show over state");
            //  m_Renderer.material = m_OverMaterial;
            var colors = GetComponent<Button>().colors;
            var text_color = m_Text.color;
            colors.normalColor = text_color;
            colors.highlightedColor = colors.normalColor;
            m_Text.color = m_Button.colors.normalColor;
            m_Button.colors = colors;

        }


        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
            var colors = GetComponent<Button>().colors;
            var text_color = m_Text.color;
            colors.normalColor = text_color;
            colors.highlightedColor = colors.normalColor;
            m_Text.color = m_Button.colors.normalColor;
            m_Button.colors = colors;
            // m_Renderer.material = m_NormalMaterial;
        }


        //Handle the Click event
        private void HandleClick()
        {
            Debug.Log("Show click state");
            if (m_Button.name == "Tutorial")
            {
                m_Canvas.enabled = false;
                m_Canvas_tutorial.enabled = true;
                m_Button.GetComponent<Collider>().enabled = false;
                m_Button2.GetComponent<Collider>().enabled = false;
            }
            else if (m_Button.name == "Start")
            {
                m_Canvas.enabled = false;
                m_Image.enabled = false;
                Simulation.flag = 1;
                m_Button.GetComponent<Collider>().enabled = false;
                m_Button2.GetComponent<Collider>().enabled = false;
                m_Button3.GetComponent<Collider>().enabled = false;
            }
            else
            { 
                m_Canvas_tutorial.enabled = false;
                m_Image.enabled = false;
                Simulation.flag = 1;
                m_Button.GetComponent<Collider>().enabled = false;
            }
        // m_Renderer.material = m_ClickedMaterial;
    }


        //Handle the DoubleClick event
        private void HandleDoubleClick()
        {
            Debug.Log("Show double click");
           // m_Renderer.material = m_DoubleClickedMaterial;
        }
    }

}
