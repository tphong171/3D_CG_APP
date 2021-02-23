using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace _18127051_BT4
{
    class Eye
    {

        public double x;        // Tọa độ x của mắt.
        public double y;        // Tọa độ y của mắt. 
        public double z;        // Tọa độ z của mắt.
        public double tx;       // Tọa độ x của mục tiêu.
        public double ty;       // Tọa độ y của mục tiêu.
        public double tz;       // Tọa độ z của mục tiêu.
        public Eye()            // Hàm khởi tạo.
        {
            this.x = 0.05;      // Khởi tạo tọa độ x của mắt là 0.05
            this.y = 0.02;      // Khởi tạo tọa độ x của mắt là 0.02
            this.z = 0.05;      // Khởi tạo tọa độ x của mắt là 0.05
            this.tx = 0;        // Mắt nhìn về gốc tọa độ.
            this.ty = 0;        // Mắt nhìn về gốc tọa độ.
            this.ty = 0;        // Mắt nhìn về gốc tọa độ.
        }

        public void zin() // Hàm phóng to.
        {
            this.x += (-0.1 * this.x);     // Phóng to theo tọa độ x.
            //this.y += (-0.1 * this.y);     // Phóng to theo tọa độ y.
            this.z += (-0.1 * this.z);     // Phóng to theo tọa độ z.
        }

        public void zout() // Hàm thu nhỏ.
        {
            this.x += (0.1 * this.x);      // Thu nhỏ theo tọa độ x.
            //this.y += (0.1 * this.y);      // Thu nhỏ theo tọa độ y.
            this.z += (0.1 * this.z);      // Thu nhỏ theo tọa độ z.
        }

        public void up()                    // Hàm di chuyển mắt lên.
        {
            this.y += (-0.01);
        }

        public void down()                  // Hàm di chuyển mắt xuống.
        {
            this.y += 0.01;
        }
        public void left()                  // Hàm di chuyển mắt qua trái.
        {
            this.x += (-0.01);
        }

        public void right()                 // Hàm di chuyển mắt qua phải.
        {
            this.x += 0.01;
        }

        public void draw(OpenGL gl)         // Hàm vẽ mắt.
        {
            gl.PointSize(10);               // Kích cỡ của mắt.
            gl.Color(1f, 0.4f, 0.5f);       // Màu mắt.
            gl.Begin(OpenGL.GL_POINTS);     // Bắt đầu vẽ mắt.
            gl.Vertex(this.x, this.y, this.z);
            gl.End();   // Kết thúc vẽ mắt.
        }
    }
}
