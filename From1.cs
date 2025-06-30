using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Newtonsoft.Json;
using System.IO;


namespace Excel_Json
{
    public partial class From1 : Form
    {
        private string filePath = string.Empty;// 全局变量，用于保存选择的文件路径
        private string selectedFolderPath;  // 保存选择的文件夹路径
        private int Col;  // 保存用户输入的列数
        private int Row;  // 保存用户输入的行数
        public From1()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            // 创建 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置打开文件对话框的初始目录
            openFileDialog.InitialDirectory = "c:\\";
            // 设置文件过滤器
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // 显示对话框并判断用户是否选择了文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取文件路径并赋值给全局变量 filePath
                filePath = openFileDialog.FileName;

                // 在文本框或标签上显示文件路径
                textBoxFilePath.Text = filePath;
            }
        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            // 检查用户是否选择了文件
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("请先选择一个 Excel 文件！");
                return;
            }

            // 设置 EPPlus 的 LicenseContext
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // 打开 Excel 文件
            var fileInfo = new FileInfo(filePath);  // 使用用户选择的文件路径
            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];

                // 创建一个字典来保存转换后的数据
                var jsonDict = new Dictionary<string, Dictionary<string, object>>();

                int startColumn = 2;  // 第二列开始读取

                // 遍历所有行
                for (int row = Row; row <= worksheet.Dimension.End.Row; row++)
                {
                    // 第二列作为变量名，删除前三个字母
                    string variableName = worksheet.Cells[row,Col].Text;
                    if (variableName.Length > 3)
                    {
                        variableName = variableName.Substring(3);  // 从第四个字符开始
                    }

                    // 创建一个字典来保存属性
                    var attributes = new Dictionary<string, object>();

                    // 遍历其他列（从第三列开始），将其作为属性
                    for (int col = startColumn + 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        // 读取属性名和属性值（假设上一行为属性名）
                        string attributeName = worksheet.Cells[Row - 1, col].Text;  // 属性名在第一行
                        string attributeValue = worksheet.Cells[row, col].Text;

                        // 将属性添加到字典中
                        attributes[attributeName] = attributeValue;
                    }

                    // 将属性字典添加到主字典中，以变量名为键
                    jsonDict[variableName] = attributes;
                }

                // 将字典转换为 JSON 格式
                string jsonString = JsonConvert.SerializeObject(jsonDict, Formatting.Indented);

                // 输出 JSON 字符串
                Console.WriteLine(jsonString);

                // 在 TextBox 中预览 JSON 内容
                ShowtextBox.Text = jsonString;

                // 拼接完整的文件路径（将文件名和文件夹路径结合起来）
                string filePath = Path.Combine(selectedFolderPath, "output.json");

                // 保存 JSON 字符串到文件
                File.WriteAllText(filePath, jsonString);

                // 通知用户转换完成
                MessageBox.Show("Excel 文件已成功转换为 JSON 文件！");
            }
        }

        private void Colbutton_Click(object sender, EventArgs e)
        {
            // 验证输入是否为有效数字
            if (int.TryParse(ColtextBox.Text, out int result))
            {
                // 将数字保存到变量
                Col = result;

                // 显示保存成功的信息
                MessageBox.Show("输入的数字已保存: " + Col);
            }
            else
            {
                // 如果输入的不是数字，提示用户
                MessageBox.Show("请输入有效的数字！");
            }
        }

        private void Rowbutton_Click(object sender, EventArgs e)
        {
            // 验证输入是否为有效数字
            if (int.TryParse(RowtextBox.Text, out int result))
            {
                // 将数字保存到变量
                Row = result;

                // 显示保存成功的信息
                MessageBox.Show("输入的数字已保存: " + Row);
            }
            else
            {
                // 如果输入的不是数字，提示用户
                MessageBox.Show("请输入有效的数字！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "请选择保存文件夹";
                folderDialog.ShowNewFolderButton = true;  // 允许用户新建文件夹

                // 显示对话框并判断用户是否选择了文件夹
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取文件夹路径并保存
                    selectedFolderPath = folderDialog.SelectedPath;

                    // 在文本框或标签上显示文件夹路径
                    SavetextBox.Text = selectedFolderPath;
                }
            }
        }
    }
}
