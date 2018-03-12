
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {

        DateTime dateTime = new DateTime();
        Button[,] viTri = new Button[6, 7];
        int thangCu, namCu;

        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
      

        private void FlowCalendarPanel(object sender, PaintEventArgs e)
        {
            dateTime.ngay = int.Parse(dateTimePicker.Value.Day.ToString());
            dateTime.thang = int.Parse(dateTimePicker.Value.Month.ToString());
            dateTime.nam = int.Parse(dateTimePicker.Value.Year.ToString());
            dateTime.thu = dateTimePicker.Value.DayOfWeek.ToString();

            thangCu = dateTime.thang;
            namCu = dateTime.nam;

            viTri[0, 0] = button00;
            viTri[0, 1] = button01;
            viTri[0, 2] = button02;
            viTri[0, 3] = button03;
            viTri[0, 4] = button04;
            viTri[0, 5] = button05;
            viTri[0, 6] = button06;
            viTri[1, 0] = button10;
            viTri[1, 1] = button11;
            viTri[1, 2] = button12;
            viTri[1, 3] = button13;
            viTri[1, 4] = button14;
            viTri[1, 5] = button15;
            viTri[1, 6] = button16;
            viTri[2, 0] = button20;
            viTri[2, 1] = button21;
            viTri[2, 2] = button22;
            viTri[2, 3] = button23;
            viTri[2, 4] = button24;
            viTri[2, 5] = button25;
            viTri[2, 6] = button26;
            viTri[3, 0] = button30;
            viTri[3, 1] = button31;
            viTri[3, 2] = button32;
            viTri[3, 3] = button33;
            viTri[3, 4] = button34;
            viTri[3, 5] = button35;
            viTri[3, 6] = button36;
            viTri[4, 0] = button40;
            viTri[4, 1] = button41;
            viTri[4, 2] = button42;
            viTri[4, 3] = button43;
            viTri[4, 4] = button44;
            viTri[4, 5] = button45;
            viTri[4, 6] = button46;
            viTri[5, 0] = button50;
            viTri[5, 1] = button51;
            viTri[5, 2] = button52;
            viTri[5, 3] = button53;
            viTri[5, 4] = button54;
            viTri[5, 5] = button55;
            viTri[5, 6] = button56;

            _TinhViTri();
        }
        private void _TinhViTri()
        {
            
            int x, y;
            x = 0; y = 0;

            //Xet thu, cot doc
            if (dateTime.thu == "Sunday") y = 0;
            else if (dateTime.thu == "Monday") y = 1;
            else if (dateTime.thu == "Tuesday") y = 2;
            else if (dateTime.thu == "Wednesday") y = 3;
            else if (dateTime.thu == "Thursday") y = 4;
            else if (dateTime.thu == "Friday") y = 5;
            else y = 6;

            //Xet ngay, cot ngang
            float fngay = float.Parse(dateTime.ngay.ToString());

            for (int i = 5; i > 0; i--)
            {

                if ((fngay / 7 + 0.5) > i)
                {
                    x = int.Parse(i.ToString());
                    break;
                }  
            }
            viTri[x, y].Text = fngay.ToString();

            int _x, _y;
            _x = x;_y = y;
            
            //Chay lui
            while (_x!=0 || _y!=0)
            {
                if (_y == 0)
                {
                    _y = 6;
                    _x--;
                }
                else _y--;
                fngay--;
                if (fngay > 0) viTri[_x, _y].Text = fngay.ToString();
                else viTri[_x, _y].Text = "";
                
            }

            //Reset
            fngay = float.Parse(dateTime.ngay.ToString());
            _x = x;
            _y = y;
            int ngayCuaThang = dateTime._NgayCuaThang();

            //Chay toi
            while (_x != 5 || _y != 6)
            {
                if (_y == 6)
                {
                    _y = 0;
                    _x++;
                }
                else _y++;
                fngay++;
                if (fngay <= dateTime._NgayCuaThang()) viTri[_x, _y].Text = fngay.ToString();
                else viTri[_x, _y].Text = "";

            }
            return;
        
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTime.ngay = int.Parse(dateTimePicker.Value.Day.ToString());
            dateTime.thang = int.Parse(dateTimePicker.Value.Month.ToString());
            dateTime.nam = int.Parse(dateTimePicker.Value.Year.ToString());
            dateTime.thu = dateTimePicker.Value.DayOfWeek.ToString();
            if (thangCu!= dateTime.thang || namCu!=dateTime.nam)
                _TinhViTri();
        }
    }
}
