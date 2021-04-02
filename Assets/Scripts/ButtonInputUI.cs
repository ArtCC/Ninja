using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleInputNamespace {

	public class ButtonInputUI: MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

		public PlayerController player;

		public SimpleInput.ButtonInput button = new SimpleInput.ButtonInput();

		private void Awake() {
			Graphic graphic = GetComponent<Graphic>();

			if (graphic != null) {
				graphic.raycastTarget = true;
			}
		}

		private void OnEnable() {
			button.StartTracking();
		}

		private void OnDisable() {
			button.StopTracking();
		}

		public void OnPointerDown(PointerEventData eventData) {
			//Debug.Log("Push button");
			button.value = true;
			player.onButtonAction();
		}

		public void OnPointerUp(PointerEventData eventData) {
			//Debug.Log("Not push button");
			button.value = false;
			player.offButtonAction();
		}
	}
}