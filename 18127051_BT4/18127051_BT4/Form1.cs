using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace _18127051_BT4
{
    public partial class Form1 : Form
    {
        CoordinateGrid CoorGrid;        // Tạo đối tượng hệ tọa độ //
        Eye MyEye;                      // Tạo đối tượng mắt //
        List<Shape> list_shape;         // Danh sách chứa các hình đã vẽ //
        OpenFileDialog explorer = new OpenFileDialog();     // File Explorer để mở hình ảnh dán texture //
        int curindex;                   // Chỉ số hình được chọn //
        private Boolean can_move_cam;
        
        public Form1()
        {
            this.CoorGrid = new CoordinateGrid();        // Tạo đối tượng hệ tọa độ //
            this.MyEye = new Eye();                      // Tạo đối tượng mắt //
            this.list_shape = new List<Shape>();         // Danh sách chứa các hình đã vẽ //
            this.curindex = -1;                          // Chưa có hình nào được chọn //
            this.can_move_cam = true;                    // Có thể sử dụng các phím mũi tên để thay đổi góc nhìn.
            
            InitializeComponent();
            this.showToolTip();
        }

        private void translate_Click(object sender, EventArgs e)    // Bắt sự kiện translate một hình //
        {
            OpenGL gl = openGLControl.OpenGL;
            int index = this.objectlist.SelectedIndex;  // Chỉ số hình được chọn //
            this.list_shape[index].tx = Double.Parse(this.posx.Text);   // Gán dữ liệu để tịnh tiến hình //
            this.list_shape[index].ty = Double.Parse(this.posy.Text);   // Gán dữ liệu để tịnh tiến hình //
            this.list_shape[index].tz = Double.Parse(this.posz.Text);   // Gán dữ liệu để tịnh tiến hình //
            this.list_shape[index].draw(gl);    // Vẽ và tịnh tiến hình //
        }

        private void openGLControl_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)      // Hàm quản lí việc vẽ các hình.
        {
            OpenGL gl = openGLControl.OpenGL;       // Lấy đối tượng OpenGL.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);      // Xóa tất cả các hình đã vẽ.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);     // Chuyển qua dùng ma trận Model.View
            gl.LoadIdentity();  // Lấy ma trận đơn vị và lưu vào stack.
            gl.LookAt(MyEye.x, MyEye.y, MyEye.z, MyEye.tx, MyEye.ty, MyEye.tz, 0, 1, 0);    // Nhìn vào gốc tọa độ.
            this.updateCurrentCoordinate(); // Cập nhật vị trí mắt hiện tại.
            CoorGrid.draw(gl);      // Vẽ hệ tọa độ Oxyz.
           
            for (int i = 0; i < this.list_shape.Count; i++) // Bắt đầu vẽ các hình trong danh sách hình.
            {
                if (this.list_shape[i].is_apply_texture)    // Nếu hình đã chọn gán texture thì gán.
                {
                    this.list_shape[i].applyTexture(gl);    // Gán texture.
                }
                else this.list_shape[i].draw(gl);           // Nếu không gán texture thì chỉ vẽ bình thường.
            }
            if (this.curindex != -1)                        // Vẽ biên cho hình được chọn.
            {
                this.list_shape[curindex].drawBoundary(gl); // Gọi hàm vẽ biên cho hình được chọn.
            }
           
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)    // Hàm khởi tạo openGL control.
        {
            OpenGL gl = openGLControl.OpenGL;       // Lấy đối tượng OpenGL.
            gl.ClearColor(0, 0, 0, 0);              // Xóa màu và đặt màu nền là màu đen.
            gl.MatrixMode(OpenGL.GL_PROJECTION);    // Chuyển qua chế độ ma trận chiếu.
            gl.LoadIdentity();                      // Lấy ma trận đơn vị và đặt vào stack.
        }

        private void openGLControl_Resized(object sender, EventArgs e)      // Hàm bắt sự kiện open gl tha đổi kích thước.
        {
            OpenGL gl = openGLControl.OpenGL;       // Lấy đối tượng OpenGL.
            gl.MatrixMode(OpenGL.GL_PROJECTION);    // Chuyển qua chế độ ma trận chiếu.
            gl.Perspective(60, openGLControl.Width * 1f / openGLControl.Height,1,-1);     // Đặt chế độ chiếu theo góc nhìn 60 độ.
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);   // Hiển thị lên open gl.
        }

        private void button1_Click(object sender, EventArgs e)  // Hàm vẽ một khối lập phương.
        {
            double result;
            if(Double.TryParse(this.length.Text,out result))
            {
                OpenGL gl = openGLControl.OpenGL;       // Lấy đối tượng Open GL.
                Cube cube = new Cube();                 // Tạo khối lập phương.
                cube.edge_len = result / 2; // Đặt độ dài cạnh.
                this.objectlist.Items.Add(cube.name);   // Thêm tên khối lập phương vào danh sách.
                this.list_shape.Add(cube);      // Thêm hình đã vẽ vào danh sách các hình.
                cube.draw(gl);      // Vẽ khối lập phương.
            }
        }

        private void pyramid_Click(object sender, EventArgs e)  // Hàm vẽ một khối chóp.
        {
            double result;
            if (Double.TryParse(this.length.Text, out result))
            {
                OpenGL gl = openGLControl.OpenGL;                   // Lấy đối tượng Open GL.
                Chop chop = new Chop();                             // Tạo khối chóp.
                chop.edge_len = result / 2; // Đặt độ dài cạnh.
                chop.height = chop.edge_len * 2;                    // Đặt chiều cao khối chóp.
                this.objectlist.Items.Add(chop.name);               // Thêm tên khối chóp vào danh sách.
                this.list_shape.Add(chop);                          // Thêm khối chóp đã vẽ vào danh sách các hình.
                chop.draw(gl);                                      // Vẽ khối chóp.
            }

        }

        private void prism_Click(object sender, EventArgs e)    // Hàm vẽ một khối lăng trụ.
        {
            double result;
            if (Double.TryParse(this.length.Text, out result))
            {
                OpenGL gl = openGLControl.OpenGL;                   // Lấy đối tượng Open GL.
                LangTru langtru = new LangTru();                    // Tạo khối lăng trụ.
                langtru.edge_len = result / 2;  // Đặt độ dài cạnh.
                langtru.height = result * 2;              // Đặt chiều cao khối lăng trụ.
                this.objectlist.Items.Add(langtru.name);            // Thêm tên khối chóp vào danh sách.
                this.list_shape.Add(langtru);                       // Thêm khối chóp đã vẽ vào danh sách các hình.
                langtru.draw(gl);                                   // Vẽ khối lăng trụ.
            }
        }

        private void unlockTranformInputBox()                   // Hàm cho phép nhập các giá trị trong phép biến đổi.
        {
            // Cho phép nhập dữ liệu của phép tịnh tiến //
            this.posx.Enabled = true;
            this.posy.Enabled = true;
            this.posz.Enabled = true;
            // Cho phép nhập dữ liệu của phép co giãn //
            this.scalex.Enabled = true;
            this.scaley.Enabled = true;
            this.scalez.Enabled = true;
            // Cho phép nhập dữ liệu của phép xoay //
            this.rotatex.Enabled = true;
            this.rotatey.Enabled = true;
            this.rotatez.Enabled = true;
            // Cho phép click vào các button //
            //this.translate.Enabled = true;
            //this.scale.Enabled = true;
            //this.rotate.Enabled = true;
        }

        public void updateCurrentCoordinate()   // Hàm cập nhật tọa độ hiện tại cho mắt.
        {
            this.curx.Text = this.MyEye.x.ToString();   // Cập nhật tọa độ x của mắt.
            this.cury.Text = this.MyEye.y.ToString();   // Cập nhật tọa độ y của mắt.
            this.curz.Text = this.MyEye.z.ToString();   // Cập nhật tọa độ z của mắt.
        }

        private void objectlist_SelectedIndexChanged(object sender, EventArgs e)    // Hàm xử lí sự kiện chỉ số hình chọn thay đổi.
        {
            this.unlockTranformInputBox();  // Khi đã chọn 1 hình thì cho phép sử dụng chức năng biến đổi hình ảnh.
            this.curindex = this.objectlist.SelectedIndex;  // Gán chỉ số hình được chọn.
        }

        protected override bool ProcessCmdKey(ref Message message, Keys key)       // Hàm xử lí sự kiện nhấn phím.  
        {
            if(this.can_move_cam)
            {
                OpenGL gl = openGLControl.OpenGL;
                switch (key)
                {
                    case Keys.Z:
                        MyEye.zin();    // Nếu nhấn Z thì zoom in.
                        break;
                    case Keys.X:
                        MyEye.zout();   // Nếu nhấn X thì zoom out.
                        break;
                    case Keys.Up:       // Nếu nhấn mũi tên lên thì di chuyển mắt lên.
                        this.objectlist.SelectedIndex = -1;
                        MyEye.up();
                        break;
                    case Keys.Down:     // Nếu nhấn mũi tên xuống thì di chuyển mắt xuống.
                        this.objectlist.SelectedIndex = -1;
                        MyEye.down();
                        break;
                    case Keys.Left:     // Nếu nhấn mũi tên qua trái thì di chuyển mắt qua trái.
                        this.objectlist.SelectedIndex = -1;
                        MyEye.left();
                        break;
                    case Keys.Right:    // Nếu nhấn mũi tên qua phải thì di chuyển mắt qua phải.
                        this.objectlist.SelectedIndex = -1;
                        MyEye.right();
                        break;
                }
                return base.ProcessCmdKey(ref message, key);
            }
            return false;
        }

        private void scale_Click(object sender, EventArgs e)    // Xử lí sự kiện scale một hình.
        {
            OpenGL gl = openGLControl.OpenGL;       // Lấy đối tượng OpenGL.
            int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
            this.list_shape[index].sx = Double.Parse(this.scalex.Text); // Gán giá trị để bắt đầu scale hình.
            this.list_shape[index].sy = Double.Parse(this.scaley.Text); // Gán giá trị để bắt đầu scale hình.
            this.list_shape[index].sz = Double.Parse(this.scalez.Text); // Gán giá trị để bắt đầu scale hình.
            this.list_shape[index].draw(gl);        // Vẽ và scale hình.
        }

        private void rotate_Click(object sender, EventArgs e)   // Xử lí sự kiện xoay một hình.
        {
            OpenGL gl = openGLControl.OpenGL;                   // Lấy đối tượng OpenGL.
            int index = this.objectlist.SelectedIndex;          // Lấy chỉ số hình được chọn.
            this.list_shape[index].rx = Double.Parse(this.rotatex.Text);    // Gán giá trị để bắt đầu xoay hình.
            this.list_shape[index].ry = Double.Parse(this.rotatey.Text);    // Gán giá trị để bắt đầu xoay hình.
            this.list_shape[index].rz = Double.Parse(this.rotatez.Text);    // Gán giá trị để bắt đầu xoay hình.
            this.list_shape[index].draw(gl);                    // Vẽ và xoay hình.
        }

        private void openexplorer_Click(object sender, EventArgs e) // Xử lí sự kiện chọn tập tin hình ảnh gán texture.
        {
            if (this.explorer.ShowDialog() == DialogResult.OK)      // Hiển thi File Explorer để chọn file.
            {
                OpenGL gl = openGLControl.OpenGL;                   // Lấy đối tượng OpenGL.
                String filename = this.explorer.FileName.ToString();// Lấy tên đường dẫn file đã chọn.
                Texture texture = new Texture();                    // Tạo một texture.
                int index = this.objectlist.SelectedIndex;          // Lấy chỉ số hình được chọn.
                list_shape[index].texture.Create(gl, filename);     // Bắt đầu quá trình tạo texture để gán.
            }
        }

        private void applytexture_Click(object sender, EventArgs e) // Xử lí sự kiến gán texture.
        {
            int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
            list_shape[index].is_apply_texture = true;  // Bật biến cờ hiệu gán texture cho hình.
        }

        private void canceltexture_Click(object sender, EventArgs e)    // Xử lí sự kiến hủy gán texture.
        {
            int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
            list_shape[index].is_apply_texture = false; // Tắt biến cờ hiệu gán texture cho hình.
        }

        private void color_Click(object sender, EventArgs e)        // Xử lí sự kiện tô màu một hình.
        {
            if (colorpicker.ShowDialog() == DialogResult.OK)        // Hiển thị bảng màu và chọn màu.
            {
                int index = this.objectlist.SelectedIndex;          // Lấy chỉ số hình được chọn.
                list_shape[index].color = colorpicker.Color;        // Đặt màu đã chọn cho hình.
            }
        }

        private void posx_TextChanged(object sender, EventArgs e)   // Hàm xử lí sự kiện tịnh tiến hình.
        {
            String text = this.posx.Text;           // Lấy dữ liệu người dùng nhập.
            double result;          
            if(Double.TryParse(text,out result))    // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if(index!=-1) this.list_shape[index].tx = result;   // Gán giá trị tịnh tiến theo Ox cho hình.
            }
        }

        private void posy_TextChanged(object sender, EventArgs e) // Hàm xử lí sự kiện tịnh tiến hình.
        {
            String text = this.posy.Text;   // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].ty = result;    // Gán giá trị tịnh tiến theo Oy cho hình.
            }
        }

        private void posz_TextChanged(object sender, EventArgs e)   // Hàm xử lí sự kiện tịnh tiến hình.
        {
            String text = this.posz.Text;   // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].tz = result;    // Gán giá trị tịnh tiến theo Oz cho hình.
            }
        }

        private void scalex_TextChanged(object sender, EventArgs e) // Hàm xử lí sự kiện scale hình.
        {
            String text = this.scalex.Text; // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].sx = result;    // Gán giá trị scale theo Ox cho hình.
            }
        }

        private void scaley_TextChanged(object sender, EventArgs e) // Hàm xử lí sự kiện scale hình.
        {
            String text = this.scaley.Text; // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].sy = result;    // Gán giá trị scale theo Oy cho hình.
            }
        }

        private void scalez_TextChanged(object sender, EventArgs e) // Hàm xử lí sự kiện scale hình.
        {
            String text = this.scalez.Text; // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].sz = result;    // Gán giá trị scale theo Oz cho hình.
            }
        }

        private void rotatex_TextChanged(object sender, EventArgs e)    // Hàm xử lí sự kiện xoay hình.
        {
            String text = this.rotatex.Text;    // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].rx = result;    // Gán giá trị xoay hình theo Ox cho hình.
            }
        }

        private void rotatey_TextChanged(object sender, EventArgs e)    // Hàm xử lí sự kiện xoay hình.
        {
            String text = this.rotatey.Text;    // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].ry= result; // Gán giá trị xoay hình theo Oy cho hình.
            }
        }

        private void rotatez_TextChanged(object sender, EventArgs e)    // Hàm xử lí sự kiện xoay hình.
        {
            String text = this.rotatez.Text;    // Lấy dữ liệu người dùng nhập.
            double result;
            if (Double.TryParse(text, out result))  // Kiểm tra dữ liệu nhập vào có hợp lệ không?
            {
                int index = this.objectlist.SelectedIndex;  // Lấy chỉ số hình được chọn.
                if (index != -1) this.list_shape[index].rz = result;    // Gán giá trị xoay hình theo Oz cho hình.
            }
        }

        private void showgrid_CheckedChanged(object sender, EventArgs e)        // Hàm xử lí sự kiện bật tắt lưới tọa độ.
        {
            if (this.showgrid.Checked)   // Nếu như chọn chế độ hiển thị lưới tọa độ.
            {
                this.CoorGrid.show_grid = true; // Hiển thị lưới tọa độ.
            }
            else this.CoorGrid.show_grid = false;   // Không hiển thị lưới tọa độ.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   // Bắt sự kiện bật, tắt chế độ thay đổi góc nhìn.
        {
            if (this.canmovecam.Checked)        // Nếu như bật chế độ thay đổi góc nhìn.
            {
                this.can_move_cam = true;       // Cho phép dùng các phím mũi tên và Z,X.
            }
            else this.can_move_cam = false;     // Không cho phép dùng các phím mũi tên và Z,X.
        }

        private void showToolTip()              // Hàm gợi ý việc nhập dữ liệu sao cho hợp lệ.
        {
            // Gợi ý việc nhập dữ liệu sao cho hợp lệ cho độ dài cạnh //
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(this.length, "Input a real number in range [0,1]");    // Độ dài cạnh hợp lệ.

            // Gợi ý việc nhập dữ liệu sao cho hợp lệ phép tịnh tiến  //
            ToolTip tooltip2 = new ToolTip();
            tooltip2.SetToolTip(this.posx, "Input a real number in range [-1,1]"); // tọa độ x hợp lệ.
            ToolTip tooltip3 = new ToolTip();
            tooltip3.SetToolTip(this.posy, "Input a real number in range [-1,1]"); // tọa độ y hợp lệ.
            ToolTip tooltip4 = new ToolTip();
            tooltip4.SetToolTip(this.posz, "Input a real number in range [-1,1]"); // tọa độ z hợp lệ.
            // Gợi ý việc nhập dữ liệu sao cho hợp lệ phép tịnh xoay  //
            ToolTip tooltip5 = new ToolTip();
            tooltip5.SetToolTip(this.rotatex, "Input a degree in range [0,360]"); // góc xoay x hợp lệ.
            ToolTip tooltip6 = new ToolTip();
            tooltip6.SetToolTip(this.rotatey, "Input a degree in range [0,360]"); // góc xoay y hợp lệ.
            ToolTip tooltip7 = new ToolTip();
            tooltip7.SetToolTip(this.rotatez, "Input a degree in range [0,360]"); // góc xoay z hợp lệ.
        }
    }
}