﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Entry.Views
{
    public class MenuButton : MonoBehaviour
    {
        public event Action OnClick;

        [SerializeField]
        protected Button button;

        [SerializeField]
        private TextMeshProUGUI textMesh;

        public void Initialize(string text)
        {
            textMesh.text = text;

            button.onClick.AddListener(() => { OnClick?.Invoke(); });
        }

        public virtual void SetActive(bool value)
        {
            button.interactable = value;
        }

        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }
    }
}
