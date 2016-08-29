using UnityEngine;
using UnityEngine.UI;

namespace Assets.ImagePicker
{
    public class ImagePicker : MonoBehaviour
    {
        /// <summary>
        /// Default prefix text for the label
        /// </summary>
        [SerializeField]
        private string filePathTextPrefix = "Seletected file: ";

        /// <summary>
        /// Text component
        /// </summary>
        [SerializeField]
        private Text filePathText;

        /// <summary>
        /// Show the image picker
        /// </summary>
        public void SelectImage()
        {
            AndroidUtils.SelectImage("ImagePicker", "OnImageSelected");
        }

        /// <summary>
        /// Image picker callback
        /// </summary>
        /// <param name="filePath">null if picking was cancelled</param>
        public void OnImageSelected(string filePath)
        {
            //do something meaningful with selected path
            Debug.Log("OnImageSelected: " + filePath);
            filePathText.text = filePathTextPrefix + (filePath ?? "null");
        }
    }
}
