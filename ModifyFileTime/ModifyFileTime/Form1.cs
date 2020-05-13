using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModifyFileTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @".//";
                openFileDialog.Title = "请选择要打开的文件";
                openFileDialog.Filter = "所有文件|*.*";
                string filepath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName.ToString();
                    textBox1.Text = filepath;
                    FileInfo fileInfo = new FileInfo(filepath);
                    this.dateTimePicker2.Value = fileInfo.CreationTime;
                    this.dateTimePicker3.Value = fileInfo.LastWriteTime;
                    this.dateTimePicker4.Value = fileInfo.LastAccessTime;
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("打开失败，请检查权限");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

      
        /// <summary>
        /// 修改文件创建时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyCreationTime_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text.ToString();
            if (filepath != string.Empty)
            {
                try
                {
                    File.SetCreationTime(filepath, dateTimePicker2.Value);
                    MessageBox.Show("修改成功");
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("修改失败,权限问题,并且请检查文件的只读属性");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
        }
        /// <summary>
        /// 修改文件写入时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyLastWriteTime_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text.ToString();
            if (filepath != string.Empty)
            {
                try
                {
                    File.SetLastWriteTime(filepath, dateTimePicker3.Value);
                    MessageBox.Show("修改成功");
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("修改失败,权限问题,并且请检查文件的只读属性");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
        }

        private void btnModifyLastAccessTime_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text.ToString();
            if (filepath != string.Empty)
            {
                try
                {
                    File.SetLastAccessTime(filepath, dateTimePicker4.Value);
                    MessageBox.Show("修改成功");
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("修改失败,权限问题,并且请检查文件的只读属性");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
        }
    }
}
