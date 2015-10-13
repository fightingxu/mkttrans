using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gzdemo
{
    public partial class FormMain : Form
    {
        private OraDb oraData;
        private string strTB;

        public FormMain()
        {
            InitializeComponent();
            strTB = "gztb100";            
        }

        // 更新查询组合框显示
        private void UpdateGroupCtrl()
        {
            labelID.Enabled = radioButtonQuery.Checked;
            textBoxID.Enabled = radioButtonQuery.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {        

            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin logFrm = new FormLogin(this);
            logFrm.Show();
        }

        // login
        public bool loginOracle(string strDB, string strUsername, string strPassword)
        {
            bool bOpened = false;
            string strstatus = "连接失败";
            try
            {
                string connStr = "Data Source=" + strDB + "; User=" + strUsername + ";Password=" + strPassword + 
                    ";Max Pool Size=500;";

// 连接远程数据库
//                string connStr = "Data Source=LOCAL_TEST; User=ctais2;Password=oracle;Max Pool Size=500;";
//                 string connStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.4.105)" +
//                                 "(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=CTAIS2)));Persist Security Info=True;User Id=ctais2; Password=oracle"; 

                oraData = new OraDb(connStr);
                if (oraData.connection.State == ConnectionState.Closed)
                {
                    oraData.connection.Open();
                }                    

                if (oraData.connection.State == ConnectionState.Open)
                {
                    bOpened = true;
                    strstatus = "用户" + strUsername + "已连接" + strDB + "数据库";
                }
            }
            catch (System.Exception ex)
            {
            	
            }
            loginStatusToolStripStatusLabel.Text = strstatus;
            return bOpened;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GZTB11' table. You can move, or remove it, as needed.
            //this.gZTB11TableAdapter.Fill(this.dataSet1.GZTB11);

            textBoxTb.Text = strTB;
            radioButtonQueryAll.Checked = true;
            UpdateGroupCtrl();
        }

        private void disconnectToolStripButton_Click(object sender, EventArgs e)
        {
            if (oraData.GetConnection().State == ConnectionState.Open)
            {
                oraData.CloseConnection();
            }
            loginStatusToolStripStatusLabel.Text = "关闭数据库连接成功"; 
        }

        private void createTbToolStripButton_Click(object sender, EventArgs e)
        {
            string strstatus = "创建数据库表失败";
            try
            {
                string cmmdStr = "create table " + strTB + "(id integer, name char(50), sex char(10), age integer, banji char(50))";
                oraData.RunNonQuery(cmmdStr);
                strstatus = "创建数据库表成功"; 
            }
            catch (System.Exception ex)
            {
                
            }
            loginStatusToolStripStatusLabel.Text = strstatus;        
        }

        private void insertToolStripButton_Click(object sender, EventArgs e)
        {
            string strstatus = "插入数据失败";
            try
            {
                string cmmdStr;
                for (int i = 1; i <= 30; i++)
                {
                    cmmdStr = "insert into " + strTB + "(id, name, sex, age, banji) values("
                    + "'" + i.ToString() + "',"
                    + "'name" + i.ToString() + "',"
                    + "'female',"
                    + "'" + (20 + i).ToString() + "',"
                    + "'class" + i.ToString() + "')";
                    oraData.RunNonQuery(cmmdStr);
                }

                strstatus = "插入数据成功"; 
            }
            catch (System.Exception ex)
            {
                
            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            string strstatus = "查询显示失败";
            try
            {
                string cmmdStr;
                if (radioButtonQueryAll.Checked)
                {
                    cmmdStr = "select * from " + strTB;                        
                }
                else
                {
                    cmmdStr = "select * from " + strTB + " where rownum <= " + textBoxID.Text;
                }
                dataGridView1.DataSource = oraData.FillTable(cmmdStr);                    

                // 设置第一列为只读属性
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.Turquoise;
                strstatus = "查询显示成功";
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void delCurSelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strstatus = "删除失败";
            try
            {
                string cmmdStr;
                cmmdStr = "select * from " + strTB;
                if (dataGridView1.SelectedCells == null)
                {
                }
                else
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 0)
                    {
                        string strId = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                        cmmdStr = "delete from " + strTB + " where id = " + strId;
                        oraData.RunNonQuery(cmmdStr);

                        //更新界面显示
                        cmmdStr = "select * from " + strTB;
                        dataGridView1.DataSource = oraData.FillTable(cmmdStr);

                        strstatus = "删除成功";
                    }
                    else
                    {
                        MessageBox.Show("请选择第一列再执行删除操作");
                    }                        
                }
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void delAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strstatus = "删除失败";
            try
            {
                string cmmdStr = "truncate table " + strTB;
                oraData.RunNonQuery(cmmdStr);

                //更新界面显示
                cmmdStr = "select * from " + strTB;
                dataGridView1.DataSource = oraData.FillTable(cmmdStr);

                strstatus = "删除成功";
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            string strstatus = "更新失败";
            try
            {
                string cmmdStr;
                if (dataGridView1.SelectedCells == null)
                {
                }
                else
                {
                    int nCurRowIndex = this.dataGridView1.CurrentCell.RowIndex;
                    string strId = this.dataGridView1[0, nCurRowIndex].Value.ToString().Trim();
                    string strName = this.dataGridView1[1, nCurRowIndex].Value.ToString().Trim();
                    string strSex = this.dataGridView1[2, nCurRowIndex].Value.ToString().Trim();
                    string strAge = this.dataGridView1[3, nCurRowIndex].Value.ToString().Trim();
                    string strClass = this.dataGridView1[4, nCurRowIndex].Value.ToString().Trim();

                    cmmdStr = "update " + strTB + " set name='" + strName +
                                            "', sex='" + strSex +
                                            "', age='" + strAge +
                                            "', banji='" + strClass +
                                            "' where id=" + strId;
                    oraData.RunNonQuery(cmmdStr);

                    strstatus = "更新成功";
                }
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void radioButtonQuery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGroupCtrl();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            string strstatus = "添加失败";
            try
            {
                string cmmdStr;
                if (dataGridView1.SelectedCells == null)
                {
                }
                else
                {
                    int nCurRowIndex = this.dataGridView1.CurrentCell.RowIndex;
                    //string strId = this.dataGridView1[0, nCurRowIndex].Value.ToString().Trim();
                    string strId = "100";
                    string strName = this.dataGridView1[1, nCurRowIndex].Value.ToString().Trim();
                    string strSex = this.dataGridView1[2, nCurRowIndex].Value.ToString().Trim();
                    string strAge = this.dataGridView1[3, nCurRowIndex].Value.ToString().Trim();
                    string strClass = this.dataGridView1[4, nCurRowIndex].Value.ToString().Trim();

                    cmmdStr = "insert into " + strTB + "(id, name, sex, age, banji) values("
                    + "'" + strId + "',"
                    + "'" + strName + "',"
                    + "'" + strSex + "',"
                    + "'" + strAge + "',"
                    + "'" + strClass + "')";
                    oraData.RunNonQuery(cmmdStr);

                    //更新界面显示
                    cmmdStr = "select * from " + strTB;
                    dataGridView1.DataSource = oraData.FillTable(cmmdStr);

                    strstatus = "更新成功";
                }
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void buttonTB_Click(object sender, EventArgs e)
        {
            strTB = textBoxTb.Text;
        }

        private void delTBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string strstatus = "删除当前表失败";
            try
            {
                //string cmmdStr = "drop table " + strTB;
                //oraData.RunNonQuery(cmmdStr);

                DataTable dt = new DataTable();
                this.dataGridView1.DataSource = dt;                
                //strstatus = "删除当前表成功";
            }
            catch (System.Exception ex)
            {

            }
            loginStatusToolStripStatusLabel.Text = strstatus;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTb_TextChanged(object sender, EventArgs e)
        {

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCfg frmCfg= new FormCfg();
            frmCfg.initForm();
            frmCfg.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
