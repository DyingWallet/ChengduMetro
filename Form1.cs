using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChengduMetro3._0
{
    public partial class Mainfrm : Form
    {
        [DllImport("ChengduMetroDll.dll", EntryPoint = "Init", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Init(int Mode, int Points);
        [DllImport("ChengduMetroDll.dll", EntryPoint = "Dijkstra", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Dijkstra(int Sta, int Points);
        [DllImport("ChengduMetroDll.dll", EntryPoint = "Generate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Generate(int Sta, int End);
        [DllImport("ChengduMetroDll.dll", EntryPoint = "Distance", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Distance(int n, int End);
        [DllImport("ChengduMetroDll.dll", EntryPoint = "Times", CallingConvention = CallingConvention.Cdecl)]
        public static extern float Times(int n, int End);

        static int
            Mode = 1,
            Sta = -1,
            End = -1,
            points = 0;
        string name1 = "起始点",
            name2 = "目的地";


        float Time = 0;
        int Dis = 0;
        int j = 0;
        List<Station> Stations = new List<Station>();   //站点链表
        List<Station> Route = new List<Station>();      //途经站点链表

        public Mainfrm()
        {
            InitializeComponent();
        }

        //获取出发点节点
        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < points; i++)
            {
                if (cmbStart.Text == Stations[i].Station_Name)
                {
                    Sta = Stations[i].Station_ID;
                    break;
                }
            }
            txtResult.Clear();
            txtDis.Text="预计里程";
            txtTime.Text="预计耗时";
            picMap.Refresh();
        }
        //获取目的地节点
        private void cmbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < points; i++)
            {
                if (cmbEnd.Text == Stations[i].Station_Name)
                {
                    End = Stations[i].Station_ID;
                    break;
                }
            }
            txtResult.Clear();
            txtDis.Text = "预计里程";
            txtTime.Text = "预计耗时";
            picMap.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //链接数据库
            OleDbConnection MapInfo = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\工作&学习\Homeworks\工程&实验\工程实践\工程实践_ChengduMetroQuery\ChengduMetroQuery 3.0\ChengduMetro\ChengduMetro3.0\bin\Debug\MetroDataBase.mdb");

            MapInfo.Open();
            if (MapInfo.State == ConnectionState.Open)
            {
                MessageBox.Show("已建立数据链接", "提示", MessageBoxButtons.OK);
            }

            //设定查询条目
            string strSql = "select MapInfo.ID,MapInfo.StationName,MapInfo.x,MapInfo.y from MapInfo";

            OleDbCommand sc1 = new OleDbCommand();
            sc1.CommandText = strSql;
            sc1.Connection = MapInfo;
            OleDbDataReader sda = sc1.ExecuteReader();
            while (sda.Read())
            {
                //StationName = sda.GetString(1);
                //读取数据库中的id和相应站名
                Station Info = new Station(sda.GetInt32(0), sda.GetString(1), sda.GetInt32(2), sda.GetInt32(3));
                Stations.Add(Info);
                //把站名导入到拉选框
                cmbStart.Items.Add(sda.GetString(1));
                cmbEnd.Items.Add(sda.GetString(1));
                points++;
            }
            MessageBox.Show("已完成数据读取", "提示", MessageBoxButtons.OK);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!MyCheck(Sta, name1) || !MyCheck(End, name2))
                return;

            j = 0;
            picMap.Refresh();
            txtResult.Clear();
            txtDis.Text = "预计里程";
            txtTime.Text = "预计耗时";

            //初始化权重并生成路径
            Init(Mode, points);
            Dijkstra(Sta, points);
            Generate(Sta, End);
            Dis = Distance(points, End);
            Time = Times(points, End);
            //MessageBox.Show("路径生成成功", "提示", MessageBoxButtons.OK);

            //从Dijkstra算法生成的path文件中获取路径信息
            StreamReader res = new StreamReader("Path.txt", Encoding.Default);
            string file = "";
            string[] result = new string[points];
            while ((file = res.ReadLine()) != null)
            {
                Console.WriteLine(file.ToString());
                string[] path = file.Split(',');
                foreach (string i in path)
                {
                    result[j++] = i;
                }
            }
            //比对站名ID并把所经过的站名存入路径链表
            for (int i = 0; i < j; i++)
            {
                for (int j = 0; j < points; j++)
                {
                    if (int.Parse(result[i]) == Stations[j].Station_ID)
                    {
                        Route.Add(Stations[j]);
                        break;
                    }
                }
                //Console.WriteLine(result[i].ToString());
            }

            //在文本框中输出路径
            for (int i = 0; i < j; i++)
            {
                if (i != j - 1)
                    txtResult.Text += Route[i].Station_Name + "->";
                else
                    txtResult.Text += Route[i].Station_Name;
            }

            txtDis.Text = Dis.ToString() + " Km";
            txtTime.Text = Time.ToString("f2") + " mins";
            int current = 0, next = 1;
            //进行路径绘制
            while(current < j-1)
            {
                DrawPath(Route[current].x, Route[current].y, Route[next].x, Route[next].y);
                current++;
                next = current + 1;
            }
            res.Close();
            Route.Clear();
        }

        private void chkDis_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)       //只允许单选
            {
                foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                {
                    if (chk != sender)
                    {
                        chk.Checked = false;
                    }
                }
            }
            Mode = 1;
            txtResult.Clear();
            txtDis.Text = "预计里程";
            txtTime.Text = "预计耗时";
            picMap.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Quit = MessageBox.Show("退出？", "提示", MessageBoxButtons.OKCancel);
            if (Quit == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)       //只允许单选
            {
                foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                {
                    if (chk != sender)
                    {
                        chk.Checked = false;
                    }
                }
            }
            Mode = 2;
            txtResult.Clear();
            txtDis.Text = "预计里程";
            txtTime.Text = "预计耗时";
            picMap.Refresh();
        }

        //自定义路径画笔
        private void DrawPath(int x1, int y1, int x2, int y2)
        {
            //创建图形对象
            Graphics path = picMap.CreateGraphics();
            Pen pen = new Pen(Color.Black, 6);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //绘制路径高亮
            path.DrawLine(pen, x1, y1, x2, y2);
            pen.Dispose();
            path.Dispose();
        }

        //自定义检查
        bool MyCheck(int val, string name)
        {
            if (val == -1)
            {
                MessageBox.Show("请选择" + name + "!", "错误", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }

    //自定义Station类
    public class Station
    {
        public int Station_ID = 0;
        public string Station_Name = null;
        public int x = 0;
        public int y = 0;

        public Station(int ID, string Name, int x, int y)
        {
            this.Station_ID = ID;
            this.Station_Name = Name;
            this.x = x;
            this.y = y;
        }
    }
}
