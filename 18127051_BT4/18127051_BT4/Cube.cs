using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
namespace _18127051_BT4
{
    class Cube : Shape
    {
        public static int count = 0;
        public Cube() : base()          // Hàm khởi tạo.
        {
            this.edge_len = 0.05;       // Khởi tạo độ dài cạnh của lăng trụ mặc định là 0.05*2.
            count++;                    
            this.name = "Cube " + count;    // Tạo tên cho hình.
        }

        public override void createVertexList()     // Hàm tạo và lưu danh sách tất cả điểm của hình.
        {
            //  Tạo mặt song song với mặt phẳng xOy ở phía z âm. //
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, -this.edge_len));
            //  Tạo mặt song song với mặt phẳng yOz ở phía x dương. //
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, -this.edge_len));
            //  Tạo mặt song song với mặt phẳng xOy ở phía z dương. //
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, this.edge_len));
            //  Tạo mặt song song với mặt phẳng yOz ở phía x âm. //
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, this.edge_len));
            //  Tạo mặt song song với mặt phẳng xOz ở phía y dương. //
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, this.edge_len, this.edge_len));
            //  Tạo mặt song song với mặt phẳng xOz ở phía y âm. //
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, -this.edge_len));
            this.list_vertex.Add(new Vertex(this.edge_len, -this.edge_len, this.edge_len));
            this.list_vertex.Add(new Vertex(-this.edge_len, -this.edge_len, this.edge_len));

        }

        public override void draw(OpenGL gl)    // Hàm vẽ.
        {
            gl.PushMatrix();
            this.applyTranformation(gl);        // Áp dụng các phép biến đổi.
            gl.Color(this.color.R / 255.0, this.color.G / 255.0, this.color.B / 255.0);     // Đặt màu cho đối tượng.
            gl.Begin(OpenGL.GL_QUADS);          // Bắt đầu vẽ các mặt.
            //  Tạo mặt song song với mặt phẳng xOy ở phía z âm. //
            gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            //  Tạo mặt song song với mặt phẳng yOz ở phía x dương. //
            gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            //  Tạo mặt song song với mặt phẳng xOy ở phía z dương. //
            gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);
            //  Tạo mặt song song với mặt phẳng yOz ở phía x âm. //
            gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);
            //  Tạo mặt song song với mặt phẳng xOz ở phía y dương. //
            gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            //  Tạo mặt song song với mặt phẳng xOz ở phía y âm. //
            gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);
            gl.End();

            gl.PopMatrix();
            this.createVertexList();        // Lưu danh sách các điểm đã vẽ.
        }

        public override void applyTexture(OpenGL gl)        // Hàm gán texture.
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);                // Bật chế độ gán texture.
            this.texture.Bind(gl);                          // Bắt đầu gán texture.

            gl.PushMatrix();                                // Đặt ma trận vào stack.
            this.applyTranformation(gl);
            gl.Color(1f, 1f, 1f);                           // Đặt màu mặc định cho hình là màu trắng.
            gl.Begin(OpenGL.GL_QUADS);                      // Bắt đầu vẽ từng mặt của hình.
            //  Vẽ và gán texture cho mặt song song với mặt phẳng xOy ở phía z âm. //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            //  Vẽ và gán texture cho mặt phẳng yOz ở phía x dương. //
            gl.TexCoord(0f, 1f); gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            //  Vẽ và gán texture cho mặt phẳng xOy ở phía z dương. //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);
            //  Vẽ và gán texture cho mặt phẳng yOz ở phía x âm. //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);
            //  Vẽ và gán texture cho mặt phẳng xOz ở phía y dương. //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len, this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len, this.edge_len, this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len, this.edge_len, this.edge_len);
            //  Vẽ và gán texture cho mặt phẳng xOz ở phía y âm. //
            gl.TexCoord(0f, 1f); gl.Vertex(-this.edge_len, -this.edge_len, -this.edge_len);
            gl.TexCoord(0f, 0f); gl.Vertex(this.edge_len, -this.edge_len, -this.edge_len);
            gl.TexCoord(1f, 0f); gl.Vertex(this.edge_len, -this.edge_len, this.edge_len);
            gl.TexCoord(1f, 1f); gl.Vertex(-this.edge_len, -this.edge_len, this.edge_len);

            gl.End();   // Kết thúc quá trình gán texture.
            gl.PopMatrix(); // Lấy ma trận ra khỏi stack.
            gl.Disable(OpenGL.GL_TEXTURE_2D);   // Tắt chế độ gán texture.
        }

        public override void drawBoundary(OpenGL gl)       // Hàm vẽ biên cho hình được chọn.
        {
            this.applyTranformation(gl);                   // Áp dụng các phép biển đôi hình học.
            gl.Color(255 / 255.0, 128 / 255.0, 0);         // Đặt màu mặc định cho đối tượng là màu trắng.
            gl.Begin(OpenGL.GL_LINES);                     // Bắt đầu vẽ các đoạn thẳng viền.
            for(int i=1;i<=6;i++)                          // Viền cho 6 mặt.
            {
                for(int j=0;j<4;j++)                       // Viền 4 cạnh của mỗi mặt.
                {
                    int m = 4 * (i-1)+j;                   // Tính toán và chọn ra từng cạnh.
                    int n = m + 1;                         // Tính toán và chọn ra từng cạnh.
                    if (n >= 4*i) n = 4*(i-1);             // Tính toán và chọn ra từng cạnh.
                    gl.Vertex(this.list_vertex[m].x, this.list_vertex[m].y, this.list_vertex[m].z); // Điểm bắt đầu của cạnh.
                    gl.Vertex(this.list_vertex[n].x, this.list_vertex[n].y, this.list_vertex[n].z); // Điểm kết thúc scủa cạnh.
                }
            }
            gl.End();       // Kết thúc quá trình vẽ viền.
        }

    }
}
