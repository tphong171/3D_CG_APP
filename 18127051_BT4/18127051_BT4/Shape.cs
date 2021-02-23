using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace _18127051_BT4
{
    class Shape
    {

        protected List<Vertex> list_vertex;         // Danh sách các điểm của hình.
        public static int count = 0;                // Số lượng đối tượng đã tạo.
        public String name;                         // Tên của đối tượng.
        public double edge_len;                     // Độ dài cạnh khi tạo đối tượng.
        public double height;                       // Chiều của của khối chóp, lăng trụ.
        public Color color;                         // Màu sắc của đối tượng.
        public Texture texture;                     // Texture của đối tượng.
        public Boolean is_apply_texture;            // Biến cờ hiệu có dán texture cho đối tượng hay không?
        public double tx, ty, tz;                   // tx, ty, tz độ dời trong phép tịnh tiến.
        public double sx, sy, sz;                   // sx, sy, sz độ co giãn trong phép scale.
        public double rx, ry, rz;                   // Góc xoay đối với từng trục Ox, Oy, Oz.
        
        public Shape()
        {
            this.list_vertex = new List<Vertex>();          // Khởi tạo danh sách các điểm.
            this.texture = new Texture();                   // Khởi tạo biến chứa texture.
            this.is_apply_texture = false;                  // Gán biến cờ hiệu chưa áp dụng texture.
            this.color= Color.FromArgb(255, 255, 255);      // Gán mã màu mặc định cho đối tượng là màu trắng.
            this.tx = 0;                                    // Độ tịnh tiến theo Ox là 0.
            this.ty = 0;                                    // Độ tịnh tiến theo Oy là 0.
            this.tz = 0;                                    // Độ tịnh tiến theo Oz là 0.
            this.sx = 1;                                    // Độ co giãn theo Ox là 1.
            this.sy = 1;                                    // Độ co giãn theo Oy là 1.
            this.sz = 1;                                    // Độ co giãn theo Oz là 1.
            this.rx = 0;                                    // Góc xoay đối với trục Ox.
            this.ry = 0;                                    // Góc xoay đối với trục Oy.
            this.rz = 0;                                    // Góc xoay đối với trục Oz.
            count++;                                        // Tăng số đối tượng đã khởi tạo lên 1.
            this.name = "Object " + count.ToString();       // Tạo tên đối tượng.
        }

        public void applyTranformation(OpenGL gl)           // Hàm áp dụng các phép biến đổi hình học lên đối tượng.
        {
            gl.Translate(this.tx, this.ty, this.tz);        // Tịnh tiến đối tượng.
            gl.Scale(this.sx, this.sy, this.sz);            // Co giãn đối tượng.
            double radtodeg = Math.PI / 180;                // Chuyển từ độ sang rad.
            gl.Rotate((float)(this.rx), (float)(this.ry), (float)(this.rz));   // Xoay đối tượng.
        }
        

        public virtual void createVertexList()              // Hàm ảo tạo tất cả các điểm của hình (được ghi đè bởi lớp con).
        {

        }

        public virtual void draw(OpenGL gl)                 // Hàm ảo tạo tất cả các điểm của hình (được ghi đè bởi lớp con).
        {

        }

        public virtual void applyTexture(OpenGL gl)         // Hàm ảo gán texture cho hình (được ghi đè bởi lớp con).
        {

        }

        public virtual void drawBoundary(OpenGL gl)         // Hàm vẽ biên màu cam của hình được chọn (được ghi đè bởi lớp con).
        {

        }

    }
}
