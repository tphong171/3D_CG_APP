using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace _18127051_BT4
{
    class Chop:Shape
    {
        public static int count = 0;
        public Chop() : base()      // Hàm khởi tạo cho hình.
        {
            this.edge_len = 0.05;   // Độ dài mặc định của 1 cạnh là 0.05*2
            count++;
            this.name = "Parymid " + count;    // Tạo tên cho hình.
        }

        public override void createVertexList()     // Hàm tạo và lưu danh sách các đỉnh của hình.
        {
            // Vẽ mặt đáy của hình chóp //
            this.list_vertex.Add(new Vertex(-this.edge_len,0, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len,0, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len,0, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len,0, this.edge_len));
            // Vẽ mặt phẳng phía sau //
            this.list_vertex.Add(new Vertex(0, this.height, 0));
            this.list_vertex.Add(new Vertex(-this.edge_len,0, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len,0, -this.edge_len));
            // Vẽ mặt phẳng phía bên phải //
            this.list_vertex.Add(new Vertex(0, this.height, 0));
            this.list_vertex.Add(new Vertex(this.edge_len,0, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len,0, this.edge_len));
            // Vẽ mặt phẳng phía trước //
            this.list_vertex.Add(new Vertex(0, this.height, 0));
            this.list_vertex.Add(new Vertex(this.edge_len,0, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len,0, this.edge_len));
            // Vẽ mặt phẳng phía bên trái ///
            this.list_vertex.Add(new Vertex(0, this.height, 0));
            this.list_vertex.Add(new Vertex(-this.edge_len,0, -this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len,0, this.edge_len));
        }
        public override void draw(OpenGL gl)    // Hàm vẽ hình.
        {
            gl.PushMatrix();                    // Đặt ma trận vào stack.
            this.applyTranformation(gl);        // Áp dụng các phép biến đổi hình học.
            gl.Color(this.color.R / 255.0, this.color.G / 255.0, this.color.B / 255.0);     // Đặt màu mặc định của hình là màu trắng.

            gl.Begin(OpenGL.GL_POLYGON);        // Bắt đầu quá trình vẽ mặt đáy.
            gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.Vertex(this.edge_len,0, -this.edge_len);
            gl.Vertex(this.edge_len,0, this.edge_len);
            gl.Vertex(-this.edge_len,0, this.edge_len);
            gl.End();


            gl.Begin(OpenGL.GL_TRIANGLES);
            // Vẽ mặt phẳng phía sau //
            gl.Vertex(0, this.height, 0);
            gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.Vertex(this.edge_len,0, -this.edge_len);
            // Vẽ mặt phẳng phía bên phải //
            gl.Vertex(0, this.height, 0);
            gl.Vertex(this.edge_len,0, -this.edge_len);
            gl.Vertex(this.edge_len,0, this.edge_len);
            // Vẽ mặt phẳng phía trước //
            gl.Vertex(0, this.height, 0);
            gl.Vertex(this.edge_len,0, this.edge_len);
            gl.Vertex(-this.edge_len,0, this.edge_len);
            // Vẽ mặt phẳng phía bên trái //
            gl.Vertex(0, this.height, 0);
            gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.Vertex(-this.edge_len,0, this.edge_len);
            gl.End();
            gl.PopMatrix();     // Lấy ma trận ra khỏi stack.
            this.createVertexList();    // Lưu danh sách các đỉnh đã vẽ.
        }

        public override void applyTexture(OpenGL gl)        // Áp dụng texture cho hình.
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);                // Bật chế độ gán texture cho hình.
            this.texture.Bind(gl);                          // Bind hình ảnh vào texture.
            gl.PushMatrix();                                // Đặt ma trận vào stack.
            this.applyTranformation(gl);                    // Áp dụng các phép biến đổi hình học.
            gl.Color(1f, 1f, 1f);                           // Đặt màu mặc định cho đối tượng là màu trắng.

            gl.Begin(OpenGL.GL_POLYGON);
            // Vẽ mặt đáy của hình chóp //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len,0, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len,0, this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len,0, this.edge_len);
            gl.End();


            gl.Begin(OpenGL.GL_TRIANGLES);
            // Vẽ mặt phẳng phía sau //
            gl.TexCoord(0f, 1f); gl.Vertex(0, this.height, 0);
            gl.TexCoord(0f, 0f); gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len,0, -this.edge_len);

            // Vẽ mặt phẳng bên phải //
            gl.TexCoord(0f, 1f); gl.Vertex(0, this.height, 0);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len,0, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len,0, this.edge_len);
            // Vẽ mặt phẳng phía trước //
            gl.TexCoord(0f, 1f); gl.Vertex(0, this.height, 0);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len,0, this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(-this.edge_len,0, this.edge_len);
            // Vẽ mặt phẳng bên trái //
            gl.TexCoord(0f, 1f); gl.Vertex(0, this.height, 0);
            gl.TexCoord(0f, 0f); gl.Vertex(-this.edge_len,0, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(-this.edge_len,0, this.edge_len);
            gl.End();   // Kết thúc quá trình gán texture.
            gl.PopMatrix(); // Lấy ma trận ra khỏi stack.
            gl.Disable(OpenGL.GL_TEXTURE_2D);   // Tắt chế độ gán texture.
        }

        public override void drawBoundary(OpenGL gl)    // Hàm vẽ biên cho hình được chọn.
        {
            this.applyTranformation(gl);                // Áp dụng các phép biển đôi hình học.
            int from = 4;
            gl.Color(255 / 255.0, 128 / 255.0, 0);      // Đặt màu mặc định cho đối tượng là màu trắng.
            gl.Begin(OpenGL.GL_LINES);                  // Bắt đầu vẽ các đoạn thẳng viền.
            for (int i = 1; i <= 3; i++)                // Viền cho 3 mặt. Mặt đáy tự viền theo.
            {
                for (int j = 0; j < 3; j++)             // Viền 3 cạnh của mỗi mặt.
                {
                    int m = 3 * (i - 1) + j + from;     // Tính toán và chọn ra từng cạnh.
                    int n = m + 1;                      // Tính toán và chọn ra từng cạnh.
                    if (n >= 3 * i + from) n = 3 * (i - 1) + from;      // Tính toán và chọn ra từng cạnh.
                    gl.Vertex(this.list_vertex[m].x, this.list_vertex[m].y, this.list_vertex[m].z);     // Điểm bắt đầu của cạnh viền.
                    gl.Vertex(this.list_vertex[n].x, this.list_vertex[n].y, this.list_vertex[n].z);     // Điểm kết thúc của cạnh viền.
                }
            }
            gl.End();       // Kết thúc quá trình viền biên hình được chọn.
        }
    }
}
