using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace _18127051_BT4
{
    class CoordinateGrid
    {

        private double len;             // Độ dài của trục Ox, Oy, Oz.
        public Boolean show_grid;      // Có hiển thị lưới tọa độ hay không?
        public CoordinateGrid()         // Hàm khởi tạo giá trị mặc định cho độ dài của các trục tọa độ.
        {
            this.len = 1;               // Mặc định độ dài là 1.
            this.show_grid = true;      // Mặc định là không hiển thị lưới tọa độ.
        }

        public void drawOx(OpenGL gl)   // Hàm vẽ trục Ox.
        {
            gl.LineWidth(2);            // Độ dày của nét vẽ là 2.
            gl.Color(1f, 0, 0, 0);      // Màu mặc định là màu đỏ.
            gl.Begin(OpenGL.GL_LINES);  // Bắt đầu vẽ đường thẳng.
            gl.Vertex(-this.len, 0, 0); // Điểm bắt đầu.
            gl.Vertex(this.len, 0, 0);  // Điểm kết thúc.
            gl.End();                   // Kết thúc vẽ đường thẳng.
        }

        public void drawOy(OpenGL gl)   // Hàm vẽ trục Oy.
        {
            gl.LineWidth(2);            // Độ dày của nét vẽ là 2.
            gl.Color(0, 1f, 0, 0);      // Màu mặc định là màu xanh lá.
            gl.Begin(OpenGL.GL_LINES);  // Bắt đầu vẽ đường thẳng.
            gl.Vertex(0, -this.len, 0); // Điểm bắt đầu.
            gl.Vertex(0, this.len, 0);  // Điểm kết thúc.
            gl.End();                   // Kết thúc vẽ đường thẳng.
        }

        public void drawOz(OpenGL gl)   // Hàm vẽ trục Oz.
        {
            gl.LineWidth(2);            // Độ dày của nét vẽ là 2.
            gl.Color(0, 0, 1f, 0);      // Màu mặc định là màu xanh dương.
            gl.Begin(OpenGL.GL_LINES);  // Bắt đầu vẽ đường thẳng.
            gl.Vertex(0, 0, -this.len); // Điểm bắt đầu.
            gl.Vertex(0, 0, this.len);  // Điểm kết thúc.
            gl.End();                   // Kết thúc vẽ đường thẳng.
        }


        public void drawGrid(OpenGL gl) // Hàm vẽ lưới tọa độ.
        {
            gl.LineWidth(1);
            gl.Color(1f, 1f, 1f);
            gl.Begin(OpenGL.GL_LINES);  // Bắt đầu quá trình vẽ lưới tọa độ.
            for(double i=-1.0;i<1;i+=0.04)   
            {
                // Vẽ các đường thẳng song song trục Ox.
                gl.Vertex(1, 0, i);     
                gl.Vertex(-1, 0, i);
                // Vẽ các đường thẳng song song trục Oz.
                gl.Vertex(i, 0, 1);
                gl.Vertex(i, 0, -1);
            }



            gl.End();                   // Kết thúc quá trình vẽ lưới tọa độ.
        }
        public void draw(OpenGL gl)     // Hàm vẽ hệ tọa độ.
        {
            gl.PushMatrix();            // Đặt ma trận vào stack.
            this.drawOx(gl);            // Vẽ trục Ox.
            this.drawOy(gl);            // Vẽ trục Oy.
            this.drawOz(gl);            // Vẽ trục Oz.
            if(this.show_grid) this.drawGrid(gl);
            gl.PopMatrix();             // Hàm xóa ma trận ra khỏi stack.
        }

    }
}
