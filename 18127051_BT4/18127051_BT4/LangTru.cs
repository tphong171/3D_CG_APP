using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace _18127051_BT4
{
    class LangTru : Shape
    {
        public static int count = 0;
        public LangTru() : base() // Hàm khởi tạo.
        {
            this.edge_len = 0.05; // Ban kinh duong tron ngoại tiếp mặt đáy.
            count++;
            this.name = "Prism " + count;    // Tạo tên cho hình.
        }

        public override void createVertexList()     // Hàm tạo và lưu danh sách các đỉnh của hình.
        {

            double degtorad = Math.PI / 180;        // Chuyển đổi từ độ sang radian.
            // Vẽ mặt đáy bên dưới //
            this.list_vertex.Add(new Vertex(0, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            // Vẽ mặt đáy bên trên //
            this.list_vertex.Add(new Vertex(0, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            // Vẽ mặt phía sau //
            this.list_vertex.Add(new Vertex(0, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            this.list_vertex.Add(new Vertex(0, this.edge_len, -this.edge_len));
            // Vẽ mặt phía bên phải //
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad)));
            // Vẽ mặt phía bên trái //
            this.list_vertex.Add(new Vertex(0, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            this.list_vertex.Add(new Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad)));
            this.list_vertex.Add(new Vertex(0, this.edge_len, -this.edge_len));


        }
        public override void draw(OpenGL gl)            // Hàm vẽ hình.
        {
            double degtorad = Math.PI / 180;            // Chuyển đổi từ độ sang radian.
            gl.PushMatrix();                            // Đặt ma trận vào stack.
            this.applyTranformation(gl);                // Áp dụng các phép biến đổi hình học.
            gl.Color(this.color.R / 255.0, this.color.G / 255.0, this.color.B / 255.0);         // Đặt màu mặc định của hình là màu trắng.


            gl.Begin(OpenGL.GL_TRIANGLES);
            // Vẽ mặt đáy bên dưới  //
            gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            // Vẽ mặt đáy bên trên  //
            gl.Vertex(0, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            // Vẽ mặt phía sau  //
            gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.Vertex(0, this.edge_len, -this.edge_len);
            // Vẽ mặt phía bên phải  //
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            // Vẽ mặt phía bên trái //
            gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.Vertex(0, this.edge_len, -this.edge_len);
            gl.End();   // Kết thúc quá trình vẽ các mặt.
            gl.PopMatrix();     // Lấy ma trận ra khỏi stack.
            this.createVertexList();        // Lưu danh sách các đỉnh của hình.
        }

        public override void applyTexture(OpenGL gl)        // Hàm gán texture.
        {
            double degtorad = Math.PI / 180;
            gl.Enable(OpenGL.GL_TEXTURE_2D);                // Bật chế độ gán texture.
            this.texture.Bind(gl);                          // Bắt đầu gán texture.

            gl.PushMatrix();                                // Đặt ma trận vào stack.
            this.applyTranformation(gl);
            gl.Color(1f, 1f, 1f);                           // Đặt màu mặc định cho hình là màu trắng.

            gl.Begin(OpenGL.GL_TRIANGLES);
            // Vẽ và gán texture mặt đáy bên dưới  //
            gl.TexCoord(0f, 1f); gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            // Vẽ và gán texture mặt đáy bên trên  //
            gl.TexCoord(0f, 1f); gl.Vertex(0, this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            // Vẽ và gán texture mặt phía sau  //
            gl.TexCoord(0f, 1f); gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.TexCoord(1f, 1f); gl.Vertex(0, this.edge_len, -this.edge_len);
            // Vẽ và gán texture mặt phía bên phải  //
            gl.TexCoord(0f, 1f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), -this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.TexCoord(1f, 1f); gl.Vertex(this.edge_len * Math.Cos(30 * degtorad), this.edge_len, this.edge_len * Math.Sin(30 * degtorad));
            // Vẽ và gán texture mặt phía bên trái //
            gl.TexCoord(0f, 1f); gl.Vertex(0, -this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), -this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len * Math.Cos(150 * degtorad), this.edge_len, this.edge_len * Math.Sin(150 * degtorad));
            gl.TexCoord(1f, 1f); gl.Vertex(0, this.edge_len, -this.edge_len);
            gl.End();   // Kết thúc quá trình vẽ các mặt.

            gl.PopMatrix(); // Lấy ma trận ra khỏi stack.
            gl.Disable(OpenGL.GL_TEXTURE_2D);   // Tắt chế độ gán texture.
        }

        public override void drawBoundary(OpenGL gl)        // Hàm vẽ biên cho hình được chọn.
        {
            this.applyTranformation(gl);                    // Áp dụng các phép biển đôi hình học.
            int from = 6;                                   // Tính toán và chọn ra từng cạnh.
            gl.Color(255 / 255.0, 128 / 255.0, 0);          // Đặt màu mặc định cho đối tượng là màu trắng.
            gl.Begin(OpenGL.GL_LINES);                      // Bắt đầu vẽ các đoạn thẳng viền.
            for (int i = 1; i <= 3; i++)                    // Viền cho 3 mặt. 2 Mặt đáy tự viền theo.
            {   
                for (int j = 0; j < 4; j++)                 // Viền 4 cạnh của mỗi mặt.
                {
                    int m = 4 * (i - 1) + j + from;         // Tính toán và chọn ra từng cạnh.
                    int n = m + 1;                          // Tính toán và chọn ra từng cạnh.
                    if (n >= 4 * i+from) n = 4 * (i - 1) + from;    // Tính toán và chọn ra từng cạnh.
                    gl.Vertex(this.list_vertex[m].x, this.list_vertex[m].y, this.list_vertex[m].z); // Điểm bắt đầu của cạnh viền.
                    gl.Vertex(this.list_vertex[n].x, this.list_vertex[n].y, this.list_vertex[n].z); // Điểm kết thúc của cạnh viền.
                }
            }
            gl.End();   // Kết thúc quá trình vẽ biên cho hình.
        }
    }
}