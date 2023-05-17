using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FreeDraw {
    public class MouseControll : MonoBehaviour
    {
        Vector3 mousePosition;
        Vector3 worldPosition;
        public Color MouseColor;
        public SpriteRenderer MousePointer;
        private void start()
        {
            MousePointer.enabled = false;
        }
        private void Update()
        {
            
            // Lấy vị trí con trỏ chuột trong không gian màn hình
            mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane;

            // Chuyển đổi vị trí con trỏ chuột từ không gian màn hình sang không gian thế giới
            worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Đặt vị trí của hình tròn bằng vị trí con trỏ chuột
            transform.position = worldPosition;

            // Lấy giá trị cuộn chuột để điều chỉnh kích cỡ hình tròn
            float scrollValue = Input.mouseScrollDelta.y;

            // Tăng hoặc giảm kích cỡ hình tròn dựa trên giá trị cuộn chuột
            transform.localScale += new Vector3(scrollValue, scrollValue, 0f);

            // Đổi màu theo màu chọn
            MouseColor = Drawable.Pen_Colour;
            MousePointer.color = MouseColor;

            // Nếu nhấn chuột thì sẽ xuất hiện
            if(Input.GetMouseButton(0)){
                MousePointer.enabled = true;
            }
            else
            {
                MousePointer.enabled = false;
            }
        }
    }
}