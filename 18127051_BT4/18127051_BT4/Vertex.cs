using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18127051_BT4
{
    class Vertex
    {

        public double x, y, z;      // Tọa độ x, y, z của một điểm.

        public Vertex()             // Hàm khởi tạo một điểm.
        {
            x = 0;                  // Tọa độ x mặc định là 0.
            y = 0;                  // Tọa độ y mặc định là 0.
            z = 0;                  // Tọa độ z mặc định là 0.
        }
        public Vertex(double x, double y, double z)     // Hàm khởi tạo nạp chồng.
        {
            this.x = x;     // Copy tọa độ x và gán vào cho hình.
            this.y = y;     // Copy tọa độ y và gán vào cho hình.
            this.z = z;     // Copy tọa độ z và gán vào cho hình.
        }
        public Vertex(Vertex V)     // Hàm copy constructor.
        {   
            x = V.x;                // Copy tọa độ x và gán vào cho hình.
            y = V.y;                // Copy tọa độ y và gán vào cho hình.
            z = V.z;                // Copy tọa độ z và gán vào cho hình.
        }

    }
}
